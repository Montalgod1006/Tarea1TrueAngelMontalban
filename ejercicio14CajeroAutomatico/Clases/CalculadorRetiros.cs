using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio14CajeroAutomatico.Clases
{
    public class CalculadorRetiros
    {
        public int [] billetes { get; set; }
        public CalculadorRetiros()
        {
            billetes = new int [] {500, 100, 50, 20,10,5} ;
        }
        
        public int SimularRetiro(int retiro, int saldo )
        {
            if(retiro%20==0)
            {
                if(retiro<=saldo)
                {
                    saldo = saldo - retiro;
                    foreach ( int billete in billetes)
                    {
                        int cantidad = retiro/billete;
                            if(cantidad>0)
                            {
                                Console.WriteLine(cantidad +"Billetes de: " + billete);
                                retiro%=billete;
                            }
                    }
                }     
                else
                Console.WriteLine("Excede al saldo");
            }
            else
            Console.WriteLine("Cantidad invalida");
            
            return saldo;
        }
    }
}