using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio8SalarioS.Clases
{
    public class CalculadoraSalario
    {
        public double CalcularSalarioBase(double tarifa, int horas)
        {
            double salarioBase;
            salarioBase = tarifa * horas;       
            return salarioBase;
        }
        public double CalcularHorasExtras(double tarifaHx, int horas)
        {
            double salarioHx;
            if(horas>44)
            {
                salarioHx = (44*tarifaHx) + (horas-44)*(tarifaHx*1.5+tarifaHx);
            }
            else
                salarioHx = horas*tarifaHx;

            return salarioHx;
        }
    }
}