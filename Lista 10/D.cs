using System;

byte[,] nums = new byte[10, 10];

Console.WriteLine("\nMATRIZ NORMAL:");
for (byte i = 0; i < nums.GetLength(0); i++)
{
    Console.Write("|");
    for (byte j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = (byte)(j + 1);
        Console.Write($" {nums[i, j]} |");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");
Console.WriteLine("ELEMENTOS DA MATRIZ, EXCETO OS DA LINHA DIAGONAL:");
for (byte i = 0; i < nums.GetLength(0); i++)
{
    for (byte j = 0; j < nums.GetLength(1); j++)
    {
        if (j == 0)
            Console.Write("|");
        if (i != j)
            Console.Write($" {nums[i, j]} |");
        else Console.Write("   |");
    }
    Console.WriteLine();
}