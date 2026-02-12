using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio15TablaMultiplicar.Clases
{
    public class MostrartablaMultiplicar
    {
        public int [] cantidad { get; set; }
        public MostrartablaMultiplicar()
        {
            cantidad = new int [] {1,2,3,4,5,6,7,8,9,10,11,12};
        }
        public void MostrarTabla(int numero)
        {
            int multiplicación;
            foreach (int recorrido in cantidad)
            {
                multiplicación = numero * recorrido;
                Console.WriteLine(numero+ " x " + recorrido + " = " + multiplicación );
            }
        }
    }
}