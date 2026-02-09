using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio7ConversionesA.Clases
{
    public class Conversiones
    {
            public double KbaMb (double kb)
        {
            double mb;
            mb = kb/1024.0;
            return mb;
        }
        public double MbaGb (double mb)
        {
            double gb;
            gb = mb/1024.0;
            return gb;
        }
        public double GbaTb (double gb)
        {
            double tb;
            tb = gb/1024.0;
            return tb;
        }
        public double TbaKb (double tb)
        {
            double kb;
            kb = tb * 1073741824.0;
            return kb;
        }
    }
}