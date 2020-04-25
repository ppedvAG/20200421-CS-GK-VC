using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Classes
{
    static class Umrechnung
    {
        internal static double CmToM(double cm)
        {
            return cm * 0.01;
        }

        public static double MToCm(double m)
        {
            return m * 100;
        }
    }
}
