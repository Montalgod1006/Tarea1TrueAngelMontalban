using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio12Añobisiesto.Clases
{
    public class IdentificadorBisiestos
    {
        public void IdentificarBisiestos(int año, int mes)
        {
            int bisiesto = 0, dias;
            string bisiestoIdentiti;
            if(año%4==0&&año%100!=12)
            {
                bisiesto = 1;
                bisiestoIdentiti = "es Bisiesto";
            }
            else
            bisiestoIdentiti = "no es Bisiesto";
            
            if(mes ==1||mes ==3||mes ==5||mes == 7||mes == 8||mes == 10|| mes == 12)
            dias = 31;
            else if (mes ==4||mes ==6||mes==9||mes==11)
            dias = 30;
            else if(bisiesto==1)
            dias = 29;
            else
            dias = 28;

            Console.WriteLine("El año " + bisiestoIdentiti);
            Console.WriteLine("El mes tiene: "+ dias +" días");
        }
    }
}