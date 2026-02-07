using ejercicio6AreaP.Clases;
AreayPerimetro areaP = new AreayPerimetro();
noNegativo Nneg = new noNegativo();
int b, a, r, OP = 0;
do
{
    Console.WriteLine("Presione cualquier tecla para continuar....");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Calculadora de Area y Perímetro");
    Console.WriteLine("1.Circulo\n2.Triángulo\n3.Rectángulo\n4.Trapecio\n5.Salir");
    OP = int.Parse(Console.ReadLine());
    switch (OP)
    {
        case 1:
                Console.WriteLine("Ingrese el radio del circulo: ");
                r = int.Parse(Console.ReadLine());
                r = Nneg.positivoConverter(r);
                areaP.AreaCirculo(r);
        break;
        case 2:
                Console.WriteLine("Ingrese la base del triangulo: ");
                b = int.Parse(Console.ReadLine());
                b = Nneg.positivoConverter(b);

                Console.WriteLine("Ingrese la altura del triangulo: ");
                a = int.Parse(Console.ReadLine());
                a = Nneg.positivoConverter(a);
                areaP.AreaTriangulo(b,a);

        break;
        case 3:
                Console.WriteLine("Ingrese primer lado del rectángulo: ");
                b = int.Parse(Console.ReadLine());
                b = Nneg.positivoConverter(b);
                 Console.WriteLine("Ingrese segundo lado del rectángulo: ");
                a = int.Parse(Console.ReadLine());
                a = Nneg.positivoConverter(a);
                areaP.AreaRectangulo(b,a);
        break;
        case 4:
                Console.WriteLine("Ingrese la base Mayor: ");
                b = int.Parse(Console.ReadLine());
                b = Nneg.positivoConverter(b);
                Console.WriteLine("Ingrese la base menor: ");
                r = int.Parse(Console.ReadLine());
                r = Nneg.positivoConverter(r);
                Console.WriteLine("Ingrese la altura: ");
                a = int.Parse(Console.ReadLine());
                a = Nneg.positivoConverter(a);
                areaP.AreaTrapecio(b,r,a);
        break;
        case 5:
                Console.WriteLine("Adios");
        break;
        default:
            Console.WriteLine("error, opción invalida");
        break;
    }
} while (OP!=5);
