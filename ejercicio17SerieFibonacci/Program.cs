using ejercicio17SerieFibonacci.Clases;
ValidarDatos validar = new ValidarDatos();
NFibonacci fibonacci = new NFibonacci();
int op, n;
do
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("MOSTRADOR DE SERIE DE FIBONACCI");
    Console.WriteLine("1.Mostrar N numeros de la serie Fibonacci\n2.Salir\nINGRESE OPCION: ");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
             Console.WriteLine("Ingrese cantidad de números a ver: ");
             n = int.Parse(Console.ReadLine());
             n = validar.validadorPositivos(n);
             fibonacci.SerieFibonacci(n);
        break;
        case 2:
            Console.WriteLine("Adios");
        break;
        default:
        Console.WriteLine("Error, opción Invalida");
        break;
    }
} while (op!=2);