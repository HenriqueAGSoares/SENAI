using System;

Console.Write("Insira um número inteiro positivo: ");
uint num = uint.Parse(Console.ReadLine());
Console.WriteLine($"Todos os divisores do número {num}:");

for (uint i = 1; i < num; i++)
    if (num % i == 0)
        Console.WriteLine(i);