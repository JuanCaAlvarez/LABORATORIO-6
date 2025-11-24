// See https://aka.ms/new-console-template for more information

int[] edades = { 18, 20, 15, 30, 45, 12 };


Console.Write("Ingrese la edad a buscar: ");


string entrada = Console.ReadLine()!;
int buscado = int.Parse(entrada);


int posicion = Array.IndexOf(edades, buscado);

if (posicion != -1)
{
    Console.WriteLine($"Encontrado en la posición {posicion}");
}
else
{
    Console.WriteLine("No se encontró la edad.");
}