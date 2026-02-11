using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio13ValidarFecha.Clases
{
    public class ValidadorFecha
    {
        public void ValidadorDeFecha (int año, int mes, int dia)
        {
            int bisiesto = 0, dias;
            if(año%4==0&&año%100!=12)
            {
                bisiesto = 1;
            }
            
            if(mes ==1||mes ==3||mes ==5||mes == 7||mes == 8||mes == 10|| mes == 12)
            dias = 31;
            else if (mes ==4||mes ==6||mes==9||mes==11)
            dias = 30;
            else if(bisiesto==1)
            dias = 29;
            else
            dias = 28;
            if(dia>dias)
            {
                Console.WriteLine("Fecha Invalida, sobrepasa los días, día máximo del mes: " + dias);
            }
            else
                Console.WriteLine("fecha Real: " + año+"/" +mes+"/" +dia );
        }
    }
}