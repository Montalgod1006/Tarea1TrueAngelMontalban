using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio23EstadisticasC.Clases
{
    public class CalculadoraPromedioMaxMin
    {
        public double Promedio (int [] notas)
        {
            int suma=0;
            double promedio;
            for (int i = 0; i < notas.Length; i++)
            {
                suma+=notas[i];
            }
            promedio = suma/notas.Length;
            return promedio;
        }
        public void MaxYMin (int [] notas)
        {
            int mayor =0, menor =100;
            int aprobados=0, reprobados =0;
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i]<menor)
                menor = notas[i];
                if(notas[i]>mayor)
                mayor = notas[i];
                if(notas[i]>=65)
                aprobados++;
                else
                reprobados++;                
            }
            Console.WriteLine("La nota mayor fue de: " + mayor);
            Console.WriteLine("La nota menor fue de: " + menor);
            Console.WriteLine("La cantidad de personas que aprobaron fue de: "+ aprobados);
            Console.WriteLine("La cantidad de personas que reprobaron fue de: "+ reprobados);
        }
        public double desviaciónEstandar (int [] notas, double promedio)
        {
            double desviacionE=0.0, x2=0.0;
            for (int i = 0; i < notas.Length; i++)
            {
                x2 = x2 + Math.Pow((notas[i]-promedio),2);
            }
            desviacionE = Math.Sqrt(x2/notas.Length);

            return desviacionE;
        }
    }
}