using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio10CalUnah.Clases
{
    public class AproboOReprobo
    {
        string letra, aprobo = "Aprobo";
        public AproboOReprobo (int nota)
        {
            if(nota>=90)
                letra = "A";
            else if(nota>=80)
                letra = "B";
            else if(nota>=70)
                letra = "C";
            else if(nota>=65)
            letra = "D";
            else
            {
                letra="F";
                aprobo = "Reprobó";
            }
            Console.WriteLine("Descripción: " + letra + " "+ aprobo);
        }
    }
}