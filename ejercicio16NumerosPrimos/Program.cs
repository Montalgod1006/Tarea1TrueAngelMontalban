using ejercicio16NumerosPrimos.Clases;
int op, n1, n2;
ValidarDatos validar = new ValidarDatos();
PrimosRango rango = new PrimosRango();
do
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("MOSTRADOR DE NUMEROS PRIMOS EN RANGO");
    Console.WriteLine("1.Mostrar números Primos\n2.Salir\nINGRESE OPCION: ");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
        do
        {
             Console.WriteLine("Ingrese inicio del rango: ");
             n1 = int.Parse(Console.ReadLine());
             n1 = validar.validadorPositivos(n1);
             Console.WriteLine("Ingrese fin del rango: ");
             n2 = int.Parse(Console.ReadLine());
             n2 = validar.validadorPositivos(n2);
             if(n1>=n2)
             Console.WriteLine("Rango Invalido, volver a ingresar datos");
        } while (n1>=n2);
        Console.WriteLine("Rango de números Primos: ");
            rango.RangoPrimos(n1,n2);
        break;
        case 2:
            Console.WriteLine("Adios");
        break;
        default:
        Console.WriteLine("Error, opción Invalida");
        break;
    }
} while (op!=2);
