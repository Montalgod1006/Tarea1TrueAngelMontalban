using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio17SerieFibonacci.Clases
{
    public class ValidarDatos
    {
        public int validadorPositivos (int variable)
        {
            do
            {
            if(variable == 0)
            {
                Console.WriteLine("Error, vuelva a ingresar el dato: ");
                variable = int.Parse(Console.ReadLine());
            }
            if(variable<0)
            {
                variable = variable*-1;
                Console.WriteLine("Valor convertido a Positivo....");
                Console.ReadLine();
            }
            } while (variable ==0);
            return variable;
        }
    }
}