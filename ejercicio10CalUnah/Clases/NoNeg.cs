using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio10CalUnah.Clases
{
    public class NoNeg
    {
        public int positivointCon (int variable)
        {
            if(variable>100)
            {
                Console.WriteLine("Error, vuelva a ingresar la nota: ");
                variable = int.Parse(Console.ReadLine());
            }
            if(variable<0)
            {
                variable = variable*-1;
                Console.WriteLine("Valor convertido a Positivo");
            }
            return variable;
        }
    }
}