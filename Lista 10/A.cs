using System;

byte[,] nums = new byte[3, 3];

for (byte i = 0; i < nums.GetLength(0); i++)
    for (byte j = 0; j < nums.GetLength(1); j++)
        nums[i, j] = (byte)(i + 1);

for (byte i = 0; i < nums.GetLength(0); i++)
{
    for (byte j = 0; j < nums.GetLength(1); j++)
        Console.Write($"| {nums[i, j]} | ");
    Console.WriteLine();
}