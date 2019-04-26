using System;
using static System.Math;

namespace ModifiedPsychrometricApp.Models
{
    class DewPointProperties : PsychrometricInput
    {
        public  double CalculateDensity()
        {
            CalculateVolume();
            Density = (1 / V) * (1 + W);
            return Density;
        }

        public  double CalculateDewSatPressure()
        {
            return P_vd = CalculatePressure(Dewpoint);
        }

        public  double CalculateDryBulbSatPressure()
        {
            return P_s = CalculatePressure(Drybulb);
        }

        public  double CalculateEnthalpy()
        {
            CalculateHumidityRatio();
            Enthalpy = (1.005 * Drybulb) + (W * (2500 + (1.88 * Drybulb)));
            return Enthalpy;
        }

        public  double CalculateHumidityRatio()
        {
            CalculateDewSatPressure();
            double _P = 101.325;
            W = 0.622 * (P_vd / (_P - P_vd));
            return W; ;
        }

        public double CalculateRelativeHumidity()
        {
            CalculateDewSatPressure();
            CalculateDryBulbSatPressure();
            Relhumidity = ((P_vd / 1000) / (P_s / 1000)) * 100;
            return Relhumidity;
        }

        public  double CalculateVolume()
        {
            CalculateHumidityRatio();
            double p = 101.325;
            V = (0.2871 * (Drybulb + 273.15) * (1 + (1.6078 * W))) / p;
            return V;
        }

        public double CalculateWetBulbTemperature()

        {

            CalculateRelativeHumidity();
            double a =Pow((Relhumidity + 8.313659), 0.5);
            double b =Pow(Relhumidity, 1.5);
            Wetbulb = (Drybulb * (Atan(0.151977 * a))) + Atan(Drybulb + Relhumidity) - Atan(Relhumidity - 1.676331) + (0.00391838 * b * (Atan(0.023101 * Relhumidity))) - 4.686035;
            return Wetbulb;
        }
        public double CalculatePressure(double temperature)
        {
            double _t = temperature + 273;
            double _d = Pow(_t, 2);
            double _a = C111 * _d;
            double _e = Pow(_t, 3);
            double _b = C121 * _e;
            double _f = Log(_t);
            double _c = C131 * _f;
            U = (C81 / _t) + C91 + (C101 * _t) + _a + _b + _c;
            double Pressure = Exp(U);
            return Pressure / 1000;
        }
    }
}