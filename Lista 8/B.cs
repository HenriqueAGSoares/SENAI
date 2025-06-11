using System;

Console.Write("Insira um número inteiro positivo: ");
uint num = uint.Parse(Console.ReadLine());
Console.WriteLine($"Números pares entre 0 e {num}: ");
for (uint i = 2; i <= num; i += 2)
    Console.WriteLine(i);