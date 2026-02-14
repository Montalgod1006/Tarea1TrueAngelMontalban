using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio26FrecuenciaElemento.Clases
{
    public class CalcularFrecuencia
    {
        public void CalcularFrecuenciaNumeros(int [] arreglo)
        {
                            //   1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            int [] frecuenciaCalculada = {0,0,0,0,0,0,0,0,0,0};
            int contadorFC=0, igual = 0;
            int Nmayor=0, Nmenor=0;
             double frecuencia, fMayor=0.0, fMenor=1.0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                igual = 0;
                int contador=0;
                for (int j = i; j < arreglo[i]; j++)
                {
                    if (arreglo[i]==arreglo[j])
                    {
                        contador++;
                    }
                }
                frecuencia = (double)contador / arreglo.Length;
                if (frecuencia>fMayor)
                {
                    fMayor = frecuencia;
                    Nmayor = arreglo[i];
                }
                if (frecuencia<fMenor)
                {
                    fMenor = frecuencia;
                    Nmenor = arreglo[i];
                } 
                for (int k = 0; k < 10; k++)
                {
                    if (arreglo[i]== frecuenciaCalculada[k])
                    {
                        igual = 1;
                        break;
                    }
                }
                if (igual ==0)
                {
                    Console.WriteLine($"La frecuencia del numero[{arreglo[i]}] es de: " + frecuencia);
                    frecuenciaCalculada[contadorFC] = arreglo[i];
                    contadorFC++;
                }
                
                
            }
              Console.WriteLine("El numero mas frecuente es: "+ Nmayor );
              Console.WriteLine("El numero menos frecuentes es: " + Nmenor);
        }
    }
}