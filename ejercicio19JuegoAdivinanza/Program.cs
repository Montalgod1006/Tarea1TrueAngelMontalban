using ejercicio19JuegoAdivinanza.Clases;
Random rdn = new Random();
MayoroMenor pista = new MayoroMenor();
int op, numero;
do
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("ADIVINA EL NUMERO");
    Console.WriteLine("1.Jugar\n2.Salir\nINGRESE OPCION: ");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            int n = rdn.Next(0,101);
            int intentos=0;
            Console.WriteLine("NO MIRAR: " +n);

            do
            {
                intentos++;
                Console.WriteLine("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero == n)
                {
                    Console.WriteLine("GANASTE");
                    break;
                }
                else
                pista.Pista(numero,n);
            } while (intentos!=7);

            if(numero!=n)
            Console.WriteLine("PERDISTE, el numero era: "+ n);
            Console.WriteLine("No, intentos: " + intentos);
        break;
        case 2:
            Console.WriteLine("Adios");
        break;
        default:
        Console.WriteLine("Error, opción Invalida");
        break;
    }
} while (op!=2);