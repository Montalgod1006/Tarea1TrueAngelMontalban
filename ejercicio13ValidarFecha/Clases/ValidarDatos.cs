using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio13ValidarFecha.Clases
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
                Console.WriteLine("Valor convertido a Positivo");
            }
            } while (variable ==0);
            return variable;
            
        }
        public int validadorMes (int variable)
        {
            do
            {
                if(variable < 0||variable>12)
            {
                Console.WriteLine("Error, vuelva a ingresar el dato: ");
                variable = int.Parse(Console.ReadLine());
            }
            } while (variable < 0||variable>12);
            
            return variable;
        }
        public int validadorDia (int variable)
        {
            do
            {
                if(variable < 0||variable>31)
                {
                Console.WriteLine("Error, vuelva a ingresar el dato: ");
                variable = int.Parse(Console.ReadLine());
                }
            } while (variable < 0||variable>31);
            
            return variable;
        }
    }
}