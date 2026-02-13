using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio23EstadisticasC.Clases
{
    public class ValidarDatos
    {
        public int validadorPositivos (int variable)
        {
            if(variable<0)
            {
                variable = variable*-1;
                Console.WriteLine("Valor convertido a Positivo....");
                Console.ReadLine();
            }
            return variable;
        }
        public int ValidarTamaño(int variable)
        {
            while (variable==0)
            {
                Console.WriteLine("Tamaño Invalido, vuélvalo a ingresar: ");
                variable = int.Parse(Console.ReadLine());
            } 
            return variable;
        }
    }
}