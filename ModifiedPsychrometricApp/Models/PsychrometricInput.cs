using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedPsychrometricApp.Models
{
   abstract class PsychrometricInput
    {

       private double C8 = -5800.2206;
        private double C9 = 1.3914993;
        private double C10 = -0.048640239;
        private double C11 = 0.000041764768;
        private double C12 = -0.000000014452093;
        private double C13 = 6.5459673;
        private double _u;
        private double _drybulb;
        private double _wetbulb;
        private double _dewpoint;
        private double _relhumidity;
        private double _enthalpy;
        private double _density;
        private double _v; // specific volume
        private double _P_s; // Saturated pressure of water vapour at dry bulb temperature
        private double _P_v; // Saturated pressure of water vapour at wet bulb temperature
        private double _P_vd; // Saturated pressure of water vapour at wet bulb temperature
        private double _w; // Humidity Ratio

        public double C81
        {
            get
            {
                return C8;
            }

            set
            {
                C8 = value;
            }
        }

        public double C91
        {
            get
            {
                return C9;
            }

            set
            {
                C9 = value;
            }
        }

        public double C101
        {
            get
            {
                return C10;
            }

            set
            {
                C10 = value;
            }
        }

        public double C111
        {
            get
            {
                return C11;
            }

            set
            {
                C11 = value;
            }
        }

        public double C121
        {
            get
            {
                return C12;
            }

            set
            {
                C12 = value;
            }
        }

        public double C131
        {
            get
            {
                return C13;
            }

            set
            {
                C13 = value;
            }
        }

        public double U
        {
            get
            {
                return _u;
            }

            set
            {
                _u = value;
            }
        }

        public double Drybulb
        {
            get
            {
                return _drybulb;
            }

            set
            {
                _drybulb = value;
            }
        }

        public double Wetbulb
        {
            get
            {
                return _wetbulb;
            }

            set
            {
                _wetbulb = value;
            }
        }

        public double Dewpoint
        {
            get
            {
                return _dewpoint;
            }

            set
            {
                _dewpoint = value;
            }
        }

        public double Relhumidity
        {
            get
            {
                return _relhumidity;
            }

            set
            {
                _relhumidity = value;
            }
        }

        public double Enthalpy
        {
            get
            {
                return _enthalpy;
            }

            set
            {
                _enthalpy = value;
            }
        }

        public double Density
        {
            get
            {
                return _density;
            }

            set
            {
                _density = value;
            }
        }

        public double V
        {
            get
            {
                return _v;
            }

            set
            {
                _v = value;
            }
        }

        public double P_s
        {
            get
            {
                return _P_s;
            }

            set
            {
                _P_s = value;
            }
        }

        public double P_v
        {
            get
            {
                return _P_v;
            }

            set
            {
                _P_v = value;
            }
        }

        public double P_vd
        {
            get
            {
                return _P_vd;
            }

            set
            {
                _P_vd = value;
            }
        }

        public double W
        {
            get
            {
                return _w;
            }

            set
            {
                _w = value;
            }
        }

    }
}
