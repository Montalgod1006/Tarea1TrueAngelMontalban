using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio4Prestamos.clases
{
    public class CalcImpuesto
    {
        public double interesTotal (int monto, double interes, int plazo)
        {
            double interesT = ((monto/plazo) * ((interes/100)/12) ) * plazo;
            return interesT;
        }
        public double CuotaMensual(int monto, double interes, int plazo)
        {
            double cuotaM = (monto/plazo) * ((interes/100.0)/12.0) + (monto/plazo);
            return cuotaM;
        }
    }
}