using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio7ConversionesA.Clases
{
    public class NoNeg
    {
         public int positivoConverter (int variable)
        {
            if(variable==0)
            {
                while(variable==0||variable>4)
                {
                    Console.WriteLine("Dato invalido, vuelva a ingresar dato: ");
                    variable = int.Parse(Console.ReadLine());
                }
            }
            if(variable<0)
            {
                variable = variable*-1;
            }
            return variable;
        }
        public double positivoGlobalCon (double variable)
        {
            if(variable<0)
            {
                variable = variable*-1.0;
            }
            return variable;
        }
    }
}