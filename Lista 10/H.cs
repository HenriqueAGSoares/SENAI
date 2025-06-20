using System;
//using System.Runtime.Serialization.Formatters;

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

ushort somaPrim = 0, somaSec = 0;
float mediaPrim, mediaSec;
// PRIMÁRIA
Console.WriteLine("SEQUÊNCIA DIAGONAL PRIMÁRIA");
for (byte i = 0; i < nums.GetLength(0); i++)
{
    if (i == 0) Console.Write("|");
    for (byte j = 0; j < nums.GetLength(1); j++)
        if (i == j)
        {
            somaPrim += nums[i, j];
            Console.Write($" {nums[i, j]} |");
        }
}
mediaPrim = (float)(somaPrim) / nums.GetLength(0);
// SECUNDÁRIA
Console.WriteLine("\nSEQUÊNCIA DIAGONAL SECUNDÁRIA");
byte l = 0;
for (byte i = (byte)(nums.GetLength(1) - 1); i < nums.GetLength(1); i--)
{
    if (i == nums.GetLength(1) - 1) Console.Write("|");
    while (true)
    {
        Console.Write($" {nums[i, l]} |");
        somaSec += nums[i, l];
        l++;
        break;
    }
}
Console.WriteLine("\n");
mediaSec = (float)(somaSec) / nums.GetLength(0);

Console.WriteLine($"SOMA DA DIAGONAL PRINCIPAL DA MATRIZ: {somaPrim}\n" +
    $"MÉDIA DA DIAGONAL PRINCIPAL DA MATRIZ: {mediaPrim}\n" +
    $"\nSOMA DA DIAGONAL SECUNDÁRIA DA MATRIZ: {somaSec}\n" +
    $"MÉDIA DA DIAGONAL SECUNDÁRIA DA MATRIZ: {mediaSec}\n");