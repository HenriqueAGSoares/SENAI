using System;

Console.Clear();
byte[,] nums = new byte[4, 4];
byte k = 1;
for (byte i = 0; i < nums.GetLength(0); i++)
    for (byte j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = k;
        k++;
    }

Console.WriteLine("\nELEMENTOS PARES DA MATRIZ\n");
for (byte i = 0; i < nums.GetLength(0); i++)
{
    Console.Write("|");
    for (byte j = 0; j < nums.GetLength(1); j++)
        if (nums[i, j] % 2 == 0)
            Console.Write($" {nums[i, j]} |");
    Console.WriteLine();
}