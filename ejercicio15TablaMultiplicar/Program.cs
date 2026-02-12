using ejercicio15TablaMultiplicar.Clases;
int numero, op;
ValidarPositivo validar = new ValidarPositivo();
MostrartablaMultiplicar tabla = new MostrartablaMultiplicar();
do
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("MOSTRADOR DE TABLAS DE MULTIPLICAR");
    Console.WriteLine("1.MostrarTabla\n2.Salir\nINGRESE OPCION: ");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            Console.WriteLine("Ingrese numero: ");
            numero = int.Parse(Console.ReadLine());
            numero = validar.validadorPositivos(numero);
            tabla.MostrarTabla(numero);
        break;
        case 2:
            Console.WriteLine("Adios");
        break;
        default:
        Console.WriteLine("Error, opción Invalida");
        break;
    }
} while (op!=2);