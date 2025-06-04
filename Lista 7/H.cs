using System;

Console.Write("Insira um número inteiro positivo: ");
uint num = uint.Parse(Console.ReadLine());
byte i = 1;
Console.WriteLine($"Tabuada do {num}:");
while (i < 11)
{
    Console.WriteLine($"{num} * {i} = {num * i}");
    ++i;
}