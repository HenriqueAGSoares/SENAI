using System;

byte[,] nums = new byte[10, 10];

//Console.WriteLine(nums.Length);
Console.WriteLine("MATRIZ NORMAL:");
for (byte i = 0; i < nums.GetLength(0); i++)
{
    Console.Write("|");
    for (byte j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = (byte)(i + 1);
        Console.Write($" {nums[i, j]} |");
    }
    Console.WriteLine();
}
Console.WriteLine("ELEMENTOS DA MATRIZ EM LINHA DIAGONAL:");
for (byte i = 0; i < nums.GetLength(0); i++)
    Console.WriteLine($"{new string(' ', i * 3)}{nums[i, i]}");