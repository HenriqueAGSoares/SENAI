using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine($"Olá {nome}!");

        Console.ReadLine();
    }
}