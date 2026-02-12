using ejercicio18CombinacionesFactorial.Clases;
ValidarDatos validar = new ValidarDatos();
Factorial factorial = new Factorial();
int op, n, r;
long FN, FR, FNR; 
double coeficiente;
do
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("MOSTRADOR DE FACTORIAL Y COEFICIENTE BINOMIAL");
    Console.WriteLine("1.Factorial de un numero\n2.Coeficiente Binomial\n3.Salir\nINGRESE OPCIÓN: ");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
                Console.WriteLine("Ingrese numero n: ");
                n = int.Parse(Console.ReadLine());
                n = validar.validadorPositivos(n);
                FN = factorial.calcularFactorial(n);
                Console.WriteLine("el factorial es: " + FN);
        break;
        case 2:
        do
        {
                Console.WriteLine("Ingrese numero n: ");
                n = int.Parse(Console.ReadLine());
                n = validar.validadorPositivos(n);
                Console.WriteLine("Ingrese numero r: ");
                r = int.Parse(Console.ReadLine());
                r = validar.validadorPositivos(r);
                if (r>n)
                {
                    Console.WriteLine("ERROR, r no puede ser mayor que n, vuélvalos a ingresar");
                }
        } while (r>n);
                

                coeficiente= (double)factorial.calcularFactorial(n)/(factorial.calcularFactorial(r)*factorial.calcularFactorial((n-r)));
                Console.WriteLine("El coeficiente Binomial es de: " + coeficiente);
        break;
        case 3:
            Console.WriteLine("Adios");
        break;
        default:
        Console.WriteLine("Error, opción Invalida");
        break;
    }
} while (op!=3);
