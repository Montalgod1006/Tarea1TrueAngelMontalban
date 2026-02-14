using System.Security.Claims;
using ejercicio26FrecuenciaElemento.Clases;
Random rdn = new Random();
CalcularFrecuencia calcular = new CalcularFrecuencia();
int [] arreglo = new int [20];

for (int i = 0; i < 20; i++)
{
    arreglo[i] = rdn.Next(0,11);
    Console.WriteLine($"{i+1}: [{arreglo[i]}]");
}
calcular.CalcularFrecuenciaNumeros(arreglo);