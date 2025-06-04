using System;

Console.WriteLine("Insira um números inteiros positivos...");
uint[] num = new uint[5];
uint total = 0;
byte i = 0;
while (i < 5)
{
    Console.Write($"Insira o {i + 1}º número: ");
    num[i] = uint.Parse(Console.ReadLine());
    total += num[i];
    ++i;
}
Console.WriteLine($"A soma dos números inseridos é {total}.");