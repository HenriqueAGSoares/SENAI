using System;

Console.Write("Insira um número inteiro positivo: ");
uint num = uint.Parse(Console.ReadLine());
ulong resultado = 0;
for (uint i = 1; i <= num; i++)
    resultado += i;
Console.Write($"A soma dos números entre 1 e {num} é {resultado}.");