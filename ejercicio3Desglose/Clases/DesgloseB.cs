using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio3Desglose.Clases
{
    public class DesgloseB
    {
        public int [] billetes { get; set; }
        public int position { get; set; }
        public  DesgloseB()
        {
            billetes = new int [8];
            billetes[0] = 0;
            billetes[1] = 0;
            billetes[2] = 0;
            billetes[3] = 0;
            billetes[4] = 0;
            billetes[5] = 0;
            billetes[6] = 0;
            billetes[7] = 0;
        }
        public void desglosar (int cantidad)
        {
            //int n500=0, n100=0, n50=0, n20=0, n10=0, n5=0, n2=0, n1=0;
            Console.WriteLine("Para desglosar la cantidad de " + cantidad + "lempiras");
            while (cantidad != 0)
            {
                if(500<=cantidad)
                {
                    billetes[0]++;
                    cantidad= cantidad  - 500;
                }
                else if(100<=cantidad)
                {
                    billetes[1]++;
                    cantidad = cantidad -100;
                }
                else if(50<=cantidad)
                {
                    billetes[2]++;
                    cantidad = cantidad -50;
                }
                else if(20<=cantidad)
                {
                    billetes[3]++;
                    cantidad = cantidad -20;
                }
                else if(10<=cantidad)
                {
                    billetes[4]++;
                    cantidad = cantidad -10;
                }
                else if(5<=cantidad)
                {
                    billetes[5]++;
                    cantidad = cantidad -5;
                }
                else if(2<=cantidad)
                {
                    billetes[6]++;
                    cantidad = cantidad -2;
                }
                else
                {
                    billetes[7]++;
                    cantidad = cantidad -1;
                }

            }
            Console.WriteLine("Se necesitaron: ");
            if(billetes[0]!=0)
            {
                Console.WriteLine( billetes[0]+ " billetes de 500lps");
            }
            if(billetes[1]!=0)
            {
                Console.WriteLine( billetes[1]+ " billetes de 100lps");
            }
            if(billetes[2]!=0)
            {
                Console.WriteLine( billetes[2]+ " billetes de 50lps");
            }
            if(billetes[3]!=0)
            {
                Console.WriteLine( billetes[3]+ " billetes de 20lps");
            }
            if(billetes[4]!=0)
            {
                Console.WriteLine( billetes[4]+ " billetes de 10lps");
            }
            if(billetes[5]!=0)
            {
                Console.WriteLine( billetes[5]+ " billetes de 5lps");
            }
            if(billetes[6]!=0)
            {
                Console.WriteLine( billetes[6]+ " billetes de 2lps");
            }
            if(billetes[7]!=0)
            {
                Console.WriteLine( billetes[7]+ " billetes de 1lps");
            }
        }
    }
}