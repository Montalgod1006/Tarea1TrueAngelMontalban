// See https://aka.ms/new-console-template for more information
using ejercicio2Temp.Clases;
Conversiones convertir = new Conversiones();
int op1, op2, OP;
double G1, G2=0;

do
{
    Console.WriteLine("Presione Cualquier tecla para continuar");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Conversor de Temperaturas");
    Console.WriteLine("1.Conversion\n2.Salir");
    OP = int.Parse(Console.ReadLine());
        switch (OP)
    {
        case 1:
                Console.WriteLine("De Grados: ");
                Console.WriteLine("1.° Celsius\n2.° Fahrenheit\n3.° Kelvin");
                do
                {
                    op1 = int.Parse(Console.ReadLine());
                    if(op1<=0 ||op1>3)
                    Console.WriteLine("Error, opción invalidad");
                } while (op1<=0 ||op1>3);

                Console.WriteLine("Ingrese Valor: ");
                G1 = double.Parse(Console.ReadLine());

                Console.WriteLine("A Grados: ");
                Console.WriteLine("1.° Celsius\n2.° Fahrenheit\n3.° Kelvin");
                do
                {
                    op2 = int.Parse(Console.ReadLine());
                    if(op2<=0 ||op2>3||op2 == op1)
                    Console.WriteLine("Error, opción invalidad, vuelva a escoger");
                } while (op2<=0 ||op2>3||op2 == op1);

                if(op1 ==1 && op2==2)
                {
                    G2 = convertir.CelAFar(G1);
                    Console.WriteLine("°"+ G2 + " Fahrenheit");
                }
                else if (op1 ==2 && op2==1)
                {
                    G2 = convertir.FarACel(G1);
                    Console.WriteLine("°"+ G2 + " Celsius");
                }
                else if (op1 ==1 && op2==3)
                {
                    G2 = convertir.CelAKel(G1);
                    Console.WriteLine("°"+ G2 + " Kelvin");
                }
                else if (op1 ==3 && op2==1)
                {
                    G2 = convertir.KelACel(G1);
                    Console.WriteLine("°"+ G2 + " Celsius");
                }
                if(op1 ==2 && op2==3)
                {
                    G2 = convertir.FarACel(G1);
                    G1 = G2;
                    G2 = convertir.CelAKel(G1);
                    Console.WriteLine("°"+ G2 + " Kelvin");
                }
                if(op1 ==3 && op2==2)
                {
                    G2 = convertir.KelACel(G1);
                    G1 = G2;
                    G2 = convertir.CelAFar(G1);
                    Console.WriteLine("°"+ G2 + " Fahrenheit");
                }

        break;
        case 2:
                Console.WriteLine("Adios");
        break;
        default:
            Console.WriteLine("Error, código invalido");
        break;
    }
} while (OP!=2);





