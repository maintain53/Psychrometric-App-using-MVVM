using System;
using static System.Math;

namespace ModifiedPsychrometricApp.Models
{
    class RelHumidityProperties : PsychrometricInput
    {
        public double CalculateWetBulbSatPressure()
        {
            CalculateWetBulbTemperature();
            double _t = Wetbulb + 273;
            double _d = Pow(_t, 2);
            double _a = C111 * _d;
            double _e = Pow(_t, 3);
            double _b = C121 * _e;
            double _f = Log(_t);
            double _c = C131 * _f;
            U = (C81 / _t) + C91 + (C101 * _t) + _a + _b + _c;
            P_v = Exp(U);
            return P_v;
        }

        public  double CalculateDewSatPressure()
        {

            double _p = 101.325;
            CalculateWetBulbSatPressure();
            P_vd = (P_v / 1000) - (((_p - (P_v / 1000)) * (Drybulb - Wetbulb) * 1.8) / (2800 - (1.3 * ((1.8 * Drybulb) + 32))));
            return P_vd;

        }
        public double CalculateWetBulbTemperature()

        {

            double a = Pow((Relhumidity + 8.313659), 0.5);
            double b = Pow(Relhumidity, 1.5);
            Wetbulb = (Drybulb * (Atan(0.151977 * a))) + Atan(Drybulb + Relhumidity) - Atan(Relhumidity - 1.676331) + (0.00391838 * b * (Atan(0.023101 * Relhumidity))) - 4.686035;
            return Wetbulb;
        }
        public double CalculateDewPointTemperature()
        {
            CalculateDewSatPressure();
            double _c14 = 6.54;
            double _c15 = 14.526;
            double _c16 = 0.7389;
            double _c17 = 0.09486;
            double _c18 = 0.4569;
            double _u = Log(P_vd);
            double _a = Pow(_u, 2);
            double _b = _c16 * _a;
            double _c = Pow(_u, 3);
            double _d = _c17 * _c;
            double _e = Pow((P_vd), 0.1984);
            double _f = _c18 * _e;
            Dewpoint = _c14 + (_c15 * _u) + _b + _d + _f;
            return Dewpoint;

        }

        public  double CalculateDryBulbSatPressure()
        {
            double t = Drybulb + 273;
            double d = Pow(t, 2);
            double a = C111 * d;
            double e = Pow(t, 3);
            double b = C121 * e;
            double f = Log(t);
            double c = C131 * f;
            U = (C81 / t) + C91 + (C101 * t) + a + b + c;
            P_s = Exp(U);
            return P_s / 1000;
        }

        public  double CalculateHumidityRatio()
        {
            CalculateDewSatPressure();
            double _P = 101.325;
            W = 0.622 * (P_vd / (_P - P_vd));
            return W;
        }

        public  double CalculateEnthalpy()
        {
            CalculateHumidityRatio();
            Enthalpy = (1.005 * Drybulb) + (W * (2500 + (1.88 * Drybulb)));
            return Enthalpy;
        }

        public  double CalculateVolume()
        {
            CalculateHumidityRatio();
            double p = 101.325;
            V = (0.2871 * (Drybulb + 273.15) * (1 + (1.6078 * W))) / p;
            return V;
        }

        public  double CalculateDensity()
        {
            CalculateVolume();
            Density = (1 / V) * (1 + W);
            return Density;
        }
    }
}

