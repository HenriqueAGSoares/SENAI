using System;
using System.Collections.Generic;

class Principal
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(Raiz(5));
	Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA SAIR...\n");
	Console.ReadKey(true);
    }
    private static uint Raiz(uint num)
    {
        return (uint)(Math.Sqrt(num));
    }
}