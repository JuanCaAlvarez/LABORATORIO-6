// See https://aka.ms/new-console-template for more information
int[] edades = new int[5];

for (int i = 0; i < edades.Length; i++)
{
    Console.Write("Ingrese edad " + (i + 1) + ": ");
    edades[i] = int.Parse(Console.ReadLine());
}
