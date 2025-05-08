using System;

class Program
{
    static void Main()
    {
        Saudacao("Henrique");
        Console.ReadLine();
    }
    static void Saudacao(string paraQuem)
    {
        Console.WriteLine($"Bem-vindo, {paraQuem}!");
    }
}