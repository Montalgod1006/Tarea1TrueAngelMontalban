using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio21PatronAsteriscos.Clases
{
    public class PatronFiguras
    {
        public void Triangulo(int tamaño)
        {
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        public void TrianguloInverso(int tamaño)
        {
            for (int i = tamaño; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void Rombo(int tamaño)
        {
           //NO LO PUDE HACER :(
            
        }
        public void CuadradoHueco (int tamaño)
        {
            for (int i = 0; i < tamaño; i++)
            {
                if (i==0 || i == tamaño-1)
                {
                    for (int j = 0; j < tamaño; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int k = 0; k < tamaño-2; k++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}