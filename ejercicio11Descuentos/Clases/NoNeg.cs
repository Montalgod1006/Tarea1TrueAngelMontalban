using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio11Descuentos.Clases
{
    public class NoNeg
    {
        public double positivoDoubleCon (double variable)
        {
            if(variable == 0.0)
            {
                Console.WriteLine("Error, vuelva a ingresar el dato: ");
                variable = double.Parse(Console.ReadLine());
            }
            if(variable<0.0)
            {
                variable = variable*-1.0;
                Console.WriteLine("Valor convertido a Positivo");
            }
            return variable;
        }
    }
}