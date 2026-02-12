using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio20Contraseña.Clases
{
    public class ValidarContraseña
    {
        public int ValidarContra(string contraseña)
        {
            int Validar=0;
            string permitidos = "!@#$%^&*";
            if (contraseña.Length<8)
                Console.WriteLine("La contraseña es muy pequeña, añada mas caracteres");
            else if(!contraseña.Any(char.IsLower)|| !contraseña.Any(char.IsUpper))
                Console.WriteLine("la contraseña debe llevar mayúsculas y minúsculas");
            else if(!contraseña.Any(char.IsNumber))
                Console.WriteLine("la contraseña debe llevar al menos un numero");
            else if(!contraseña.Any(ch => permitidos.Contains(ch)))
                Console.WriteLine("la contraseña debe llevar al menos un dígito especial");
            else
                Validar = 1;
            return Validar;
        }
    }
}