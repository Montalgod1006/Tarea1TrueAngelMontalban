using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio24BusquedayOrdenamiento.Clases
{
    public class BusquedaYOrdenar
    {
        public void Busqueda (int dato, int []arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i]==dato)
                {
                    Console.WriteLine($"[{arreglo[i]}]");
                }
            }
        }
        public void BuscarSegundoMayor (int []arreglo)
        {
            int mayor1=0, mayor2=0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if(arreglo[i]>mayor1)
                mayor1 = arreglo[i];
            }
            for (int i = 0; i < arreglo.Length; i++)
            {
                if(arreglo[i]>mayor2&&arreglo[i]!=mayor1)
                mayor2 = arreglo[i];
            }
            Console.WriteLine($"El segundo mayor es: [{mayor2}]");
        }
        public void OrdenarAscendente (int []arreglo)
        {
            int copia;
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = i; j < arreglo.Length; j++)
                {
                    if (arreglo[j]<arreglo[i])
                    {
                        copia= arreglo[i];
                        arreglo[i] = arreglo[j];
                        arreglo[j] = copia;
                    }
                }
            }
            Console.WriteLine("Arreglo ordenado ascendentemente");
        }
        public void MostrarelementosEnPares (int[] arreglo)
        {
            int contador = 0;
            for(int i =0; i<arreglo.Length; i++)
            {
                if(contador==2)
                {
                    Console.WriteLine();
                    contador = 0;
                }

                Console.Write($"[{arreglo[i]}] ");
                contador++;
            }
        }

    }
}