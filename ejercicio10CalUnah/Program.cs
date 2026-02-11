using ejercicio10CalUnah.Clases;
NoNeg noNegatuvo = new NoNeg();
Console.WriteLine("SISTEMA DE CALIFICACIONES");
int nota;
Console.WriteLine("Ingrese la nota: ");
nota = int.Parse(Console.ReadLine());
nota = noNegatuvo.positivointCon(nota);
 new AproboOReprobo(nota);