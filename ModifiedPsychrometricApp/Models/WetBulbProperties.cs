using System;
using static System.Math;

namespace ModifiedPsychrometricApp.Models
{
    class WetBulbProperties : PsychrometricInput
    {
        public double CalculateDryBulbSatPressure()
        {
            return P_s = CalculatePressure(Drybulb);
        }

        public double CalculateRelativeHumidity()
        {
            CalculateDewSatPressure();
            CalculateDryBulbSatPressure();
            Relhumidity = (P_vd / (P_s)) * 100;
            return Relhumidity;
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
        public double CalculateWetBulbSatPressure()
        {
            return P_v = CalculatePressure(Wetbulb)*1000;
        }

        public  double CalculateDewSatPressure()
        {
            double _p = 101.325;
            CalculateWetBulbSatPressure();
            P_vd = (P_v / 1000) - (((_p - (P_v / 1000)) * (Drybulb - Wetbulb) * 1.8) / (2800 - (1.3 * ((1.8 * Drybulb) + 32))));
            return P_vd;

        }

        public double CalculateHumidityRatio()
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

