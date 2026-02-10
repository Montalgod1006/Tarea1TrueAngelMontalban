using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio9ClasificacionT.Clases
{
    public class IdentificadorTriangulo
    {
        public void identificadorTriangulo (int L1, int L2, int L3)
        {
            int valido=0;
            double A1=0.0, A2=0.0, A3=0.0;
           
                A1 = Math.Acos((L2*L2+L3*L3-L1*L1)/(2.0*L2*L3));
                A2 = Math.Acos((L1*L1+L3*L3-L2*L2)/(2.0*L1*L3));
                A3 = Math.Acos((L1*L1+L2*L2-L3*L3)/(2.0*L1*L2));
            
            if(A1==A2&&A2==A3)
                Console.WriteLine("Por sus ángulos es un triangulo rectángulo"); 
            else if (A1<90 && A2<90 && A3<90)
                Console.WriteLine("Por sus ángulos es un triangulo acutángulo"); 
            else if (A1>90||A2>90||A3>90)
                Console.WriteLine("Por sus ángulos es un triangulo obtusángulo");
            else
            {
                Console.WriteLine("TRIANGULO INVALIDO");
                valido = 1;
            }
            if(valido == 0)
            {
                if(L1 == L2 && L2 == L3)
                    Console.WriteLine("Por sus lados es un triangulo equilátero");   
                else if (L1 == L2|| L2 == L3 || L3 == L1)
                    Console.WriteLine("Por sus lados es un triangulo isósceles"); 
                else 
                    Console.WriteLine("Por sus lados es un triangulo escaleno"); 
            }
            
        }
    }
}