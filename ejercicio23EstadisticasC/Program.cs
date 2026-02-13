using ejercicio23EstadisticasC.Clases;
CalculadoraPromedioMaxMin Calcular = new CalculadoraPromedioMaxMin();
ValidarDatos validar = new ValidarDatos();
int tamaño;
int [] notas;
double promedio, desviacionE;
Console.Clear();
Console.WriteLine("Estadísticas Calificaciones");
Console.WriteLine("Ingrese tamaño del arreglo");
tamaño = int.Parse(Console.ReadLine());
tamaño = validar.ValidarTamaño(tamaño);
tamaño = validar.validadorPositivos(tamaño);
notas = new int [tamaño];
for (int i = 0; i < tamaño; i++)
{
    Console.WriteLine($"Ingrese nota [{i+1}]: ");
    notas[i] = int.Parse(Console.ReadLine());
    notas[i] = validar.validadorPositivos(notas[i]);
}
promedio = Calcular.Promedio(notas);
Console.WriteLine("el promedio es de: " + promedio);
Calcular.MaxYMin(notas);
desviacionE = Calcular.desviaciónEstandar(notas, promedio);
Console.WriteLine("la desviación estandar es de: " + desviacionE);
