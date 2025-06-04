using System;

Console.Write("Insira um número inteiro: ");
uint num = uint.Parse(Console.ReadLine()), i = 1;
Console.WriteLine($"* TABUADA DO {num} *");
while (i <= 10)
{
    Console.WriteLine($"{num} * {i} = {num * i}");
    ++i;
}