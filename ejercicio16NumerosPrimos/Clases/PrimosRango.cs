using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio16NumerosPrimos.Clases
{
    public class PrimosRango
    {
        public void RangoPrimos(int n1, int n2)
        {
            int contador=0;
            for (int i = n1; i < n2; i++)
            {
                int primo = 0;
                if(i==2)
                {
                Console.WriteLine(i);
                contador++;    
                }

                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        primo = 1;
                        break;
                    }
                }
                if (primo == 0&&i!=2&&i!=1)
                {
                    Console.WriteLine(i);
                    contador ++;
                }
            }
            if (contador == 0)
            Console.WriteLine("No hay números primos en el rango");
            else
            Console.WriteLine("hay " + contador + " en el rango");
            
        }
    }
}