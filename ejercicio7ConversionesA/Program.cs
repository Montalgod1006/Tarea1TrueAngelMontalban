using ejercicio7ConversionesA.Clases;
Conversiones convertir = new Conversiones();
NoNeg nadaNega = new NoNeg();

int op=0;
double  dato;
int unidad1, unidad2;
string u1="";
do
{
    Console.WriteLine("Presione cualquier tecla para continuar");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Convertor de unidades de almacenamiento binarios");
    Console.WriteLine("1.Conversiones\n2.Salir");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 1:
            Console.WriteLine("Ingrese primera opción");
            Console.WriteLine("1.Kb\n2.Mb\n3.Gb\n4.Tb");
            unidad1 = int.Parse(Console.ReadLine());
            unidad1 = nadaNega.positivoConverter(unidad1);

            Console.WriteLine("Cantidad a convertir: ");
            dato = double.Parse(Console.ReadLine());

            dato = nadaNega.positivoGlobalCon(dato);
            do
            {
            Console.WriteLine("Ingrese segunda opción");
            Console.WriteLine("1.Kb\n2.Mb\n3.Gb\n4.Tb");
            unidad2 = int.Parse(Console.ReadLine());
            unidad2 = nadaNega.positivoConverter(unidad2);
            if(unidad2 == unidad1)
            Console.WriteLine("No puede convertir a la misma unidad");
            } while (unidad2 == unidad1);

            while (unidad1 != unidad2)
            {
                switch (unidad1)
                {
                    case 1:
                        dato = convertir.KbaMb(dato);
                        unidad1 = 2;
                        u1 = "mb";
                    break;
                    case 2:
                        dato = convertir.MbaGb(dato);
                        unidad1 = 3;
                        u1 = "gb";
                    break;
                    case 3:
                        dato = convertir.GbaTb(dato);
                        unidad1 = 4;
                        u1 = "tb";
                    break;
                    case 4:
                        dato = convertir.TbaKb(dato);
                        if (unidad1 > unidad2)
                            unidad1 = 1;

                        u1 = "Kb";
                    break;
                }
            }

            Console.WriteLine("Dato convertido a: "+ dato + "" + u1 );
        break;
        case 2:
            Console.WriteLine("Adios");
        break;
        default:
            Console.WriteLine("Valor invalido");
        break;
    }
} while (op!=2);