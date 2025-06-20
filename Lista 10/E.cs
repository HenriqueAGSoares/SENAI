using System;

Console.Clear();
float[,] nums = { { 10.5f, 6.6f}, { 5.4f, 4.4f} };

Console.Write("MÉDIA DE TODOS OS VALORES DA MATRIZ: ");
float media = 0;
for (byte i = 0; i < nums.GetLength(0); i++)
    for (byte j = 0; j < nums.GetLength(1); j++)
        media += nums[i, j];
Console.WriteLine($"{media / (nums.GetLength(0) + nums.GetLength(1)):F2}");