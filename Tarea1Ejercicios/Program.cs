// See https://aka.ms/new-console-template for more information
using Tarea1Ejercicios.Clases;
 IMC imc = new IMC();
double peso, altura;
 Console.WriteLine("-----CALCULADORA DE IMC-----");

do
{
    Console.WriteLine("Ingrese su peso(kg): ");
    peso = double.Parse(Console.ReadLine());   
    if(peso<=0)
         Console.WriteLine("Error, no se admiten resultados negativos"); 
} while (peso<= 0);
do
{
    Console.WriteLine("Ingrese su altura(m):");
    altura = double.Parse(Console.ReadLine());  
    if(altura<=0)
        Console.WriteLine("Error, no se admiten resultados negativos"); 
} while (altura<= 0);
imc.calcularIMC(peso, altura);
imc.CatPeso();

 