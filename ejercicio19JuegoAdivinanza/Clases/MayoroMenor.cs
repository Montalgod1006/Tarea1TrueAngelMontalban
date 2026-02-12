using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio19JuegoAdivinanza.Clases
{
    public class MayoroMenor
    {
        public void Pista (int numero, int numeroRnd)
        {
            if (numero>numeroRnd)
            Console.WriteLine("Error, el numero es mas bajo");
            else 
            Console.WriteLine("Error, el numero es mas alto");
        }
    }
}