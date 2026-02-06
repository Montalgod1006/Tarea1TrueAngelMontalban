using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1Ejercicios.Clases
{
    public class IMC
    {
        public double imc { get; set; }
        public void calcularIMC(double peso, double altura)
        {
            imc = peso / (altura*altura);
            Console.WriteLine("IMC: " + imc);
        }
        public void CatPeso()
        {
            if(imc<18.5)
            Console.WriteLine("Peso bajo");
            else if (imc>=18.5 && imc<=24.9)
            Console.WriteLine("Peso Normal");
            else if (imc>=25.0 && imc<=29.9)
            Console.WriteLine("Sobrepeso");
            else if (imc>=30.0 && imc<=34.9)
            Console.WriteLine("Obesidad");
            else if (imc>34.9)
            Console.WriteLine("BALLENA");

        }
    }
}