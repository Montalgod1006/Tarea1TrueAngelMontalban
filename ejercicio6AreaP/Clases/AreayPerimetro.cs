using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ejercicio6AreaP.Clases
{
    public class AreayPerimetro
    {
        public void AreaCirculo( int radio)
        {
            double area = Math.PI*(radio*radio);
            double perimetro = 2*Math.PI*radio; 
            Console.WriteLine("El area del circulo es de: " + area);
            Console.WriteLine("El perímetro del circulo es de: " + perimetro);
        }
        public void AreaTriangulo (int Base, int altura)
        {
            double area = (Base*altura)/2.0;
            double hipotenusa = Math.Sqrt((Base*Base)+(altura*altura));
            double perimetro = Base + altura + hipotenusa;
            Console.WriteLine("El area del triangulo es de: " + area);
            Console.WriteLine("El perímetro del triangulo es de: " + perimetro);
        }
        public void AreaRectangulo (int lado1, int lado2)
        {
            int area = lado1 * lado2;
            int perimetro = (lado1*2) +(lado2*2);
            Console.WriteLine("El area del rectángulo es de: " + area);
            Console.WriteLine("El perímetro del rectángulo es de: " + perimetro);
        }
        public void AreaTrapecio(int Bmayor, int Bmenor, int altura)
        {
            double area = ((Bmayor + Bmenor)*altura) / 2.0;
            double distanciaB = (Bmayor - Bmenor) / 2.0;
            double lado = Math.Sqrt((altura*altura) + (distanciaB*distanciaB));
            double perimetro = Bmayor + Bmenor + lado*2.0;
            Console.WriteLine("El area del Trapecio es de: " + area);
            Console.WriteLine("El perímetro del es de: " + perimetro);
        }
    }
}