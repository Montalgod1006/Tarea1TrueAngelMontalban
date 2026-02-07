using System.Data.SqlTypes;
using ejercicio3Desglose.Clases;
Console.Clear();
Console.WriteLine("---------Desglose de Billetes----------");
DesgloseB desglosando = new DesgloseB();
int money;
do
{
    try
    {
        Console.WriteLine("Ingrese el monto a desmontar: ");
         money = int.Parse(Console.ReadLine());
    }
    catch (System.Exception)
    {
        Console.WriteLine("Error, dato invalido");
        throw;
    }
    if(money<=0)
    Console.WriteLine("Error, dato invalido");

} while (money<=0);

desglosando.desglosar(money);
