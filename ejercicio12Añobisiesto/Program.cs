using ejercicio12Añobisiesto.Clases;
int año, mes;
Console.Clear();
IdentificadorBisiestos idBisiesto = new IdentificadorBisiestos();
ValidadorDatos Validador = new ValidadorDatos();
Console.WriteLine("IDENTIFICADOR DE AÑOS BISIESTOS");
Console.WriteLine("Ingrese año: ");
año = int.Parse(Console.ReadLine());
año = Validador.validadorPositivos(año);
Console.WriteLine("Ingrese Mes(1-12): ");
mes = int.Parse(Console.ReadLine());
mes = Validador.validadorMes(mes);

idBisiesto.IdentificarBisiestos(año, mes);