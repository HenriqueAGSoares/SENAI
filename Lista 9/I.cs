using System;

string[] nomes = new string[10];

for (byte i = 0; i < 10; i++)
{
    Console.Write($"Insira o {i + 1}º nome: ");
    nomes[i] = Console.ReadLine();
}
for (byte i = 0; i < 10; i++)
    Console.WriteLine($"{i + 1}º nome: {nomes[i]}");