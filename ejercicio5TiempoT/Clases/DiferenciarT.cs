using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio5TiempoT.Clases
{
    public class DiferenciarT
    {
        public int[] DiferenciarH(int[] H1, int[] H2)
        {
            int [] H3 = new int [3];
            H3[0] = H1[0] - H2[0];
            if(H3[0]<0)
            H3[0] = H3[0] * -1;

            H3[1] = H1[1] - H2[1];
            if(H3[1]<0)
            H3[1] = H3[1] * -1;

            H3[2] = H1[2] - H2[2];
            if(H3[2]<0)
            H3[2] = H3[2] * -1;

            return H3;
        }
    }
}