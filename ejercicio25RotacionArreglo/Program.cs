using ejercicio25RotacionArreglo.Clases;
ValidarDatos validar = new ValidarDatos();
RotarElementos rotar = new RotarElementos();
int op, tamaño, Nposiciones;
int [] arreglo;

Console.WriteLine("Ingrese tamaño del arreglo: ");
tamaño = int.Parse(Console.ReadLine());
tamaño = validar.validadorPositivos(tamaño);
arreglo = new int [tamaño];
Console.WriteLine("Ingrese Valores del arreglo: ");
for (int i = 0; i < tamaño; i++)
{
    Console.Write($"Ingrese valor [{i+1}]: ");
    arreglo[i] = int.Parse(Console.ReadLine());
}

do
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("ROTACIÓN ARREGLO");
    Console.WriteLine("1.Rotar N posiciones a la izquierda\n2.rotar N posiciones a la derecha\n3.Invertir el Arreglo\n4.Ver arreglo\n5.Salir\nINGRESE OPCION: ");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
             Console.WriteLine("Ingrese N posiciones: ");
             Nposiciones = int.Parse(Console.ReadLine());
             Nposiciones = validar.validadorPositivos(Nposiciones);
             arreglo = rotar.RotarIzquierda(arreglo, Nposiciones);
        break;
        case 2:
                Console.WriteLine("Ingrese N posiciones: ");
             Nposiciones = int.Parse(Console.ReadLine());
             Nposiciones = validar.validadorPositivos(Nposiciones);
             arreglo = rotar.RotarDerecha(arreglo, Nposiciones);
        break;
        case 3:
            arreglo = rotar.Imvertir(arreglo);
        break;
        case 4:
                for (int i = 0; i < tamaño; i++)
                {
                    Console.WriteLine($"[{i+1}]: "+ arreglo[i]);
                }
        break;
        case 5:
            Console.WriteLine("Adios");
        break;
        default:
        Console.WriteLine("Error, opción Invalida");
        break;
    }
} while (op!=5);
