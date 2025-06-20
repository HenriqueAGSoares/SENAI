using System;

Console.Clear();

byte[,] nums = new byte[10, 10];
byte k = 1;
Console.WriteLine("\nMATRIZ NORMAL:");
for (byte i = 0; i < nums.GetLength(0); i++)
{
    Console.Write("|");
    for (byte j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = k;
        Console.Write($" {nums[i, j]} |");
        k++;
    }
    Console.WriteLine();
}
Console.WriteLine("\n");

ushort soma = 0;
for (byte i = 0; i < nums.GetLength(0); i++)
    for (byte j = 0; j < nums.GetLength(1); j++)
        soma += nums[i, j];
Console.WriteLine($"\nSOMA DE TODOS OS ELEMENTOS DA MATRIZ: {soma}");