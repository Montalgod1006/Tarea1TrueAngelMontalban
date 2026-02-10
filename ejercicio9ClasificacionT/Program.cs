using ejercicio9ClasificacionT.Clases;
NoNegativos notNegative = new NoNegativos();
IdentificadorTriangulo identitri = new IdentificadorTriangulo();
int L1, L2, L3;
Console.Clear();
Console.WriteLine("IDENTIFICADOR DE TRIÁNGULOS");

Console.WriteLine("Ingrese medida del primer lado: ");
L1 = int.Parse(Console.ReadLine());
L1 = notNegative.positivoInt(L1);
Console.WriteLine("Ingrese medida del segundo lado: ");
L2 = int.Parse(Console.ReadLine());
L2 = notNegative.positivoInt(L2);
Console.WriteLine("Ingrese medida del tercer lado: ");
L3 = int.Parse(Console.ReadLine());
L3 = notNegative.positivoInt(L3);

identitri.identificadorTriangulo(L1,L2,L3);


