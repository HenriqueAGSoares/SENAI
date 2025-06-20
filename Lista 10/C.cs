using System;

byte[,] nums = { { 4, 50 }, { 66, 78 }, { 51, 3 }, { 5, 10 } };
ushort resultado = 0;

for (byte i = 0; i < nums.GetLength(0); i++)
    for (byte j = 0; j < nums.GetLength(1); j++)
        resultado += nums[i, j];
Console.WriteLine($"SOMA DOS ELEMENTOS DA MATRIZ: {resultado}");