using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio22Calculadora.Clases
{
    public class Calculadora
    {
        public double Suma (double n1, double n2)
        {
            double suma;
            suma = n1 + n2;
            return suma;
        }
        public double Multiplicación (double n1, double n2)
        {
            double multiplicacion;
            multiplicacion = n1 * n2;
            return multiplicacion;
        }
        public double División (double n1, double n2)
        {
            double division;
            division = n1 / n2;
            return division;
        }
        public double Potencia (double n1, double n2)
        {
            double potencia;
            potencia = Math.Pow(n1, n2);
            return potencia;
        }
        public double Raíz (double n1)
        {
            double raiz;
            raiz = Math.Sqrt(n1);
            return raiz;
        }
        public double Porcentaje (double n1, double n2)
        {
            double porcentaje;
            porcentaje = n1*(n2/100.0);
            return porcentaje;
        }
    }
}