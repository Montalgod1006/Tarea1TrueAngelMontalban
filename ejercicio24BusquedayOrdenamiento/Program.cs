using ejercicio24BusquedayOrdenamiento.Clases;
BusquedaYOrdenar BusquedaO = new BusquedaYOrdenar();
int op, creado = 0;
int [] arreglo= new int [10];
do
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("BÚSQUEDA Y ORDENAMIENTO");
    Console.WriteLine("1.Ingresar datos en Arreglo\n2.Buscar Dato\n3.Buscar el segundo Mayor\n4.Ordenar de forma ascendente\n5.Mostrar En pares\n6.Salir\nINGRESE OPCION: ");
    op = int.Parse(Console.ReadLine());
    int dato;
    switch (op)
    {
        case 1:
             for (int i = 0; i < 10; i++)
             {
                Console.WriteLine($"Ingrese el dato no[{i+1}]: ");
                arreglo[i] = int.Parse(Console.ReadLine());
             }
             creado = 1;
        break;
        case 2:
        if (creado == 0)
            Console.WriteLine("DEBE INGRESAR PRIMERO DATOS AL ARREGLO");
        else
        {
            Console.Write("Ingrese dato a buscar: ");
            dato = int.Parse(Console.ReadLine());
            BusquedaO.Busqueda(dato, arreglo);
        }
        break;
        case 3:
        if (creado == 0)
            Console.WriteLine("DEBE INGRESAR PRIMERO DATOS AL ARREGLO");
        else
                BusquedaO.BuscarSegundoMayor(arreglo);
        break;
        case 4:
        if (creado == 0)
            Console.WriteLine("DEBE INGRESAR PRIMERO DATOS AL ARREGLO");
        else
                BusquedaO.OrdenarAscendente(arreglo);
        break;
        case 5:
        if (creado == 0)
            Console.WriteLine("DEBE INGRESAR PRIMERO DATOS AL ARREGLO");
        else
            BusquedaO.MostrarelementosEnPares(arreglo);
        break;
        case 6:
            Console.WriteLine("Adios");
        break;
        default:
        Console.WriteLine("Error, opción Invalida");
        break;
    }
} while (op!=6);
