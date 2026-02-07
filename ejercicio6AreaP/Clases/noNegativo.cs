using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio6AreaP.Clases
{
    public class noNegativo
    {
        public int positivoConverter (int variable)
        {
            if(variable==0)
            {
                while(variable==0)
                {
                    Console.WriteLine("No se permiten datos0, vuelva a ingresar dato: ");
                    variable = int.Parse(Console.ReadLine());
                }
            }
            if(variable<0)
            {
                variable = variable*-1;
            }
            return variable;
        }
    }
}