using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio17SerieFibonacci.Clases
{
    public class NFibonacci
    {
        public void SerieFibonacci(int n)
        {
            int numerador =0, resultado=1, n1=0, copiaR, suma=0;
            double promedio;
            while (numerador != n)
            {
                copiaR = resultado;
                resultado = n1+resultado;
                n1 = copiaR;
                numerador++;
                suma= suma + resultado;
                Console.WriteLine(resultado);
            }
            promedio = (double)suma/n;
            Console.WriteLine("La suma total de los números fue de: " + suma);
            Console.WriteLine("El promedio fue de: "+ promedio);
        }
    }
}