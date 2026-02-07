using ejercicio4Prestamos.clases;
Console.Clear();
CalcImpuesto CalculadoraImp = new CalcImpuesto();
int monto=0, plazo=0;
double interesA =0, interesT, cuotaM;
Console.WriteLine("------Calculadora de prestamos simple------");
do
{
    Console.WriteLine("Ingrese el monto con el que se endeudo: ");
    monto = int.Parse(Console.ReadLine());
    if (monto <=0)
        Console.WriteLine("Error, dato invalido");
} while (monto <=0);

do
{
    Console.WriteLine("Ingrese la tasa interés anual(en %): ");
    interesA = double.Parse(Console.ReadLine());
    if (interesA <=0||interesA>100)
        Console.WriteLine("Error, dato invalido");
} while (interesA <=0||interesA>100);

do
{
    Console.WriteLine("Ingrese el plazo en meses: ");
    plazo = int.Parse(Console.ReadLine());
    if (plazo <=0)
        Console.WriteLine("Error, dato invalido");
} while (plazo <=0);

interesT = CalculadoraImp.interesTotal(monto, interesA, plazo);
cuotaM = CalculadoraImp.CuotaMensual(monto, interesA, plazo);

Console.WriteLine("El interés total es de: " + interesT);
Console.WriteLine("La cuota mensual es de: " + cuotaM);

