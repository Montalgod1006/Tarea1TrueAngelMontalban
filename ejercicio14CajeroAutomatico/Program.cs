using ejercicio14CajeroAutomatico.Clases;
CalculadorRetiros calcularRetiros = new CalculadorRetiros();
ValidarDato validar = new ValidarDato();
int saldo = 20000, retiro, op;

do
{
    Console.WriteLine("Presione cualquier tecla");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("simulador Retiros");
    Console.WriteLine("1.Retirar\n2.Salir");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            Console.WriteLine("Su saldo es de: "+ saldo);
            Console.WriteLine("Ingrese cantidad a retirar: ");
            retiro = int.Parse(Console.ReadLine());
            retiro = validar.validadorPositivos(retiro);
            saldo = calcularRetiros.SimularRetiro(retiro,saldo);
        break;
        case 2:

        break;

        default:

        break;
    }
} while (op!=2);
