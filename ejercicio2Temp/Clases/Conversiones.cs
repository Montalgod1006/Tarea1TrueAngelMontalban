using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio2Temp.Clases
{
    public class Conversiones
    {
        public double CelAFar(double g1)
        {
            double g2;
            g2 = (9.0/5.0)*g1 +32;
            return g2;
        }
        public double FarACel(double g1)
        {
            double g2;
            g2=(g1-32)*(5.0/9.0);
            return g2;
        }
        public double CelAKel(double g1)
        {
            double g2;
            g2 = g1 +273.15;
            return g2;
        }
        public double KelACel(double g1)
        {
            double g2;
            g2 = g1 - 273.15;
            return g2;
        }
    }
}