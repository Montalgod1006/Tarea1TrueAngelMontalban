using ejercicio5TiempoT.Clases;

int [] hora1 = new int[3]; //Ingreso unos arreglos para evitar declarar muchas variables
int [] hora2 = new int[3];
int [] hora3 = new int[3];
Console.Clear();
DiferenciarT diferenciador = new DiferenciarT();
Console.WriteLine("Diferenciador de tiempo");
Console.WriteLine("Ingrese primera: Hora / minuto / segundo");
do
{
    hora1[0] = int.Parse(Console.ReadLine());
    if(hora1[0]>24||hora1[0]<0)
    Console.WriteLine("Hora invalida, vuélvala a ingresar: ");
} while (hora1[0]>24||hora1[0]<0);
Console.WriteLine(":");
do
{
    hora1[1] = int.Parse(Console.ReadLine());
    if(hora1[1]>=60||hora1[1]<0)
    Console.WriteLine("Minutos inválidos, vuélvalos a ingresar: ");
} while (hora1[1]>=60||hora1[1]<0);
Console.WriteLine(":");
do
{
    hora1[2] = int.Parse(Console.ReadLine());
    if(hora1[2]>=60||hora1[2]<0)
    Console.WriteLine("segundos inválidos, vuélvalos a ingresar: ");
} while (hora1[2]>=60||hora1[2]<0);

Console.WriteLine("Ingrese segunda: Hora / minuto / segundo");
do
{
    hora2[0] = int.Parse(Console.ReadLine());
    if(hora2[0]>24||hora2[0]<0)
    Console.WriteLine("Hora invalida, vuélvala a ingresar: ");
} while (hora2[0]>24||hora2[0]<0);
Console.WriteLine(":");
do
{
    hora2[1] = int.Parse(Console.ReadLine());
    if(hora2[1]>=60||hora2[1]<0)
    Console.WriteLine("Minutos inválidos, vuélvalos a ingresar: ");
} while (hora2[1]>=60||hora2[1]<0);
Console.WriteLine(":");
do
{
    hora2[2] = int.Parse(Console.ReadLine());
    if(hora2[2]>=60||hora2[2]<0)
    Console.WriteLine("segundos inválidos, vuélvalos a ingresar: ");
} while (hora2[2]>=60||hora2[2]<0);

hora3 = diferenciador.DiferenciarH(hora1, hora2);

Console.WriteLine("La diferencia es de: " + hora3[0] + " horas : "+ hora3[1] + " minutos : " + hora3[2] + " segundos");