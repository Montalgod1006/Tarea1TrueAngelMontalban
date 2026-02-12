using ejercicio20Contraseña.Clases;
ValidarContraseña validarC = new ValidarContraseña();
int op, valido=0;
string contraseña;
do
{
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Validador de contraseñas");
    Console.WriteLine("1.Validar contraseña\n2.Salir\nINGRESE OPCION: ");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
        do
        {
            Console.WriteLine("Ingrese su contraseña: ");
            contraseña = Console.ReadLine();
            valido = validarC.ValidarContra(contraseña);
            if (valido == 1)
            Console.WriteLine("CONTRASEÑA CREADA CON ÉXITO");
        } while (valido ==0);
            
        break;
        case 2:
            Console.WriteLine("Adios");
        break;
        default:
        Console.WriteLine("Error, opción Invalida");
        break;
    }
} while (op!=2);