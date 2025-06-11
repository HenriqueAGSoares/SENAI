using System;

uint[] v1 = new uint[5];
uint[] v2 = new uint[5];
uint[] soma = new uint[5];

Console.WriteLine("*PRIMEIRA LISTA*");
for (byte i = 0; i < 5; i++)
{
    Console.Write($"Insira o {i+1}º número: ");
    v1[i] = uint.Parse(Console.ReadLine());
}

Console.WriteLine("*SEGUNDA LISTA*");
for (byte i = 0; i < 5; i++)
{
    Console.Write($"Insira o {i+1}º número: ");
    v2[i] = uint.Parse(Console.ReadLine());
}
Console.WriteLine("\nSOMA DOS ITENS DE MESMA POSIÇÃO DAS DUAS LISTAS");
for (byte i = 0; i < 5; i++)
{
    soma[i] = v1[i] + v2[i];
    Console.WriteLine($"{i+1}ª posição: {soma[i]}.");
}