using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio18CombinacionesFactorial.Clases
{
    public class Factorial
    {
        public long calcularFactorial(int n)
        {
            long factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial*=i;
            }
            return factorial;
        }
    }
}