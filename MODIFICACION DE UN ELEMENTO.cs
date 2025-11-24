// See https://aka.ms/new-console-template for more information

int[] edades = { 15, 20, 35, 40, 50 };

Console.Write("Ingrese la posición a modificar (0-4): ");
int pos = int.Parse(Console.ReadLine());


if (pos >= 0 && pos < edades.Length)
{
    Console.Write("Ingrese el nuevo valor: ");
   
    edades[pos] = int.Parse(Console.ReadLine());

    Console.WriteLine($"¡Listo! La posición {pos} ahora vale {edades[pos]}.");
}
else
{
    Console.WriteLine("Error: Esa posición no existe en el arreglo.");
}
