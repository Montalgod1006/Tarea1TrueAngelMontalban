using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio25RotacionArreglo.Clases
{
    public class RotarElementos
    {
        public int [] RotarDerecha (int [] arreglo, int kPosiciones)
        {
            int posicion;
            int [] arregloDerecha = new int[arreglo.Length];
            for (int i = 0; i < arreglo.Length; i++)
            {
                posicion =  i+kPosiciones;
                while (posicion>=arreglo.Length)
                {
                    posicion = posicion-arreglo.Length;
                }
                arregloDerecha [posicion] = arreglo[i];
            }
            return arregloDerecha;
        }
        public int [] RotarIzquierda (int [] arreglo, int kPosiciones)
        {
            int posicion;
            int [] arregloIzquierda = new int[arreglo.Length];
            for (int i = 0; i < arreglo.Length; i++)
            {
                posicion =  i-kPosiciones;
                while (posicion<0)
                {
                    posicion = posicion+arreglo.Length;
                }
                arregloIzquierda [posicion] = arreglo[i];
            }
            return arregloIzquierda;
        }
        public int [] Imvertir (int [] arreglo)
        {
            int posicion;
            int [] arregloInvertido = new int[arreglo.Length];
            for (int i = 0; i < arreglo.Length; i++)
            {
                posicion = arreglo.Length -1 - i;
                arregloInvertido[posicion] = arreglo[i];
            }
            return arregloInvertido;
        }
    }
}