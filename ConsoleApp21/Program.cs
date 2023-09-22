Console.Write("Ingrese la cantidad de notas a promediar: ");
int cantidad = Convert.ToInt32(Console.ReadLine());
int i = 0;
int promedio = 0;
int suma = 0;
while (i < cantidad)
{
    Console.Write("Ingrese la nota "+(i+1)+" : ");
    int nota=int.Parse(Console.ReadLine());
    suma = suma + nota;
    promedio = nota / cantidad;
    i++;
}
Console.WriteLine("El promedio es: " + promedio);