using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio11Descuentos.Clases
{
    public class DescuentosCalculator
    {
        public double CalcularDescuento (double totalPurchase)
        {
            double discount = 0.0;
            if(totalPurchase>500&&totalPurchase<=999)
            discount = totalPurchase * 0.05;
            else if(totalPurchase>=1000&&totalPurchase<=2499)
            discount = totalPurchase *0.1;
            else if (totalPurchase>=2500)
            discount = totalPurchase * 0.15;
            return discount;
        }
    }
}