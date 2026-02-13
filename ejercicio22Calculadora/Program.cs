using ejercicio22Calculadora.Clases;
Calculadora calculadora = new Calculadora();
int op;
double dato1, dato2, operacion, ultimoDato = 0.0;
do
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("CALCULADORA");
    Console.WriteLine("1.Suma o resta\n\n2.Multiplicación\n3.División\n4.Potencia\n5.Raíz Cuadrada\n6.Porcentaje\n7.Salir\nINGRESE OPCION: ");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
                Console.WriteLine($"ultimo Valor [{ultimoDato}]");
                Console.WriteLine("Suma o Resta: ");
                dato1 = int.Parse(Console.ReadLine());
                Console.WriteLine("+");
                dato2 = int.Parse(Console.ReadLine());
                operacion = calculadora.Suma(dato1, dato2);
                ultimoDato = operacion;
                Console.WriteLine("= " + operacion);
        break;
        case 2:
                Console.WriteLine($"ultimo Valor [{ultimoDato}]");
                Console.WriteLine("Multiplicación: ");
                dato1 = int.Parse(Console.ReadLine());
                Console.WriteLine("*");
                dato2 = int.Parse(Console.ReadLine());
                operacion = calculadora.Multiplicación(dato1, dato2);
                ultimoDato = operacion;
                Console.WriteLine("= " + operacion);
        break;
        case 3:
                Console.WriteLine($"ultimo Valor [{ultimoDato}]");
                Console.WriteLine("División: ");
                dato1 = int.Parse(Console.ReadLine());
                Console.WriteLine("/");
                dato2 = int.Parse(Console.ReadLine());
                operacion = calculadora.División(dato1, dato2);
                ultimoDato = operacion;
                Console.WriteLine("= " + operacion);
        break;
        case 4:
                Console.WriteLine($"ultimo Valor [{ultimoDato}]");
                Console.WriteLine("Raiz : ");
                dato1 = int.Parse(Console.ReadLine());
                operacion = calculadora.Raíz(dato1);
                ultimoDato = operacion;
                Console.WriteLine("= " + operacion);
        break;
        case 5:
                Console.WriteLine($"ultimo Valor [{ultimoDato}]");
                Console.WriteLine("Potencia de: ");
                dato1 = int.Parse(Console.ReadLine());
                Console.WriteLine("^");
                dato2 = int.Parse(Console.ReadLine());
                operacion = calculadora.Potencia(dato1, dato2);
                ultimoDato = operacion;
                Console.WriteLine("= " + operacion);
        break;
        case 6:
                Console.WriteLine($"ultimo Valor [{ultimoDato}]");
                Console.WriteLine("Porcentaje : ");
                dato1 = int.Parse(Console.ReadLine());
                Console.WriteLine("% de:");
                dato2 = int.Parse(Console.ReadLine());
                operacion = calculadora.Porcentaje(dato2, dato1);
                ultimoDato = operacion;
                Console.WriteLine("= " + operacion);
        break;
        case 7:
            Console.WriteLine("Adios");
        break;
        default:
        Console.WriteLine("opción Invalida");
        break;
    }
} while (op!=7);