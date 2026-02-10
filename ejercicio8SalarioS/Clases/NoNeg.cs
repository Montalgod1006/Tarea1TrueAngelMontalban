using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio8SalarioS.Clases
{
    public class NoNeg
    {
         public int positivoConverter (int variable)
        {
            if(variable<0)
            {
                variable = variable*-1;
            }
            return variable;
        }
        public double positivoDoubleCon (double variable)
        {
            if(variable==0)
            {
                while(variable==0)
                {
                    Console.WriteLine("Dato invalido, vuelva a ingresar dato: ");
                    variable = double.Parse(Console.ReadLine());
                }
            }
            if(variable<0)
            {
                variable = variable*-1.0;
            }
            return variable;
        }
    }
}