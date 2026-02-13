using ejercicio21PatronAsteriscos.Clases;
PatronFiguras Patron = new PatronFiguras();
ValidarDatos validar = new ValidarDatos();
int tamaño, op;
do
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Dibujar figuras");
    Console.WriteLine("1.Triangulo Normal\n2.Triangulo Inverso\n3.Rombo\n4.Cuadrado Hueco\n5.Salir\nINGRESE OPCION: ");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
             Console.WriteLine("Ingrese tamaño: ");
             tamaño = int.Parse(Console.ReadLine());
             tamaño = validar.validadorPositivos(tamaño);
             Patron.Triangulo(tamaño);
        break;
        case 2:
            Console.WriteLine("Ingrese tamaño: ");
            tamaño = int.Parse(Console.ReadLine());
            tamaño = validar.validadorPositivos(tamaño);
            Patron.TrianguloInverso(tamaño);
        break;
        case 3:
            Console.WriteLine("Ingrese tamaño: ");
            tamaño = int.Parse(Console.ReadLine());
            tamaño = validar.validadorPositivos(tamaño);
            Patron.Rombo(tamaño);
        break;
        case 4:
            Console.WriteLine("Ingrese tamaño: ");
            tamaño = int.Parse(Console.ReadLine());
            tamaño = validar.validadorPositivos(tamaño);
            Patron.CuadradoHueco(tamaño);
        break;
        case 5:
            Console.WriteLine("Adios");
        break;
        default:
        Console.WriteLine("Error, opción Invalida");
        break;
    }
} while (op!=5);