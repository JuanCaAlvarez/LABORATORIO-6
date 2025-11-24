// See https://aka.ms/new-console-template for more information
int[] edades = { 18, 25, 32, 45, 12 };

Console.WriteLine("Listado de edades:");
Console.WriteLine("------------------"); // Separador visual

foreach (int edad in edades)
{
    // Agregamos "- " para que parezca una lista
    Console.WriteLine($"- {edad} años");
}
