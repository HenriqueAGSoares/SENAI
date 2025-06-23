using System;
using System.Collections.Generic;

class Principal
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(Soma(5, 50));
	Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA SAIR...\n");
	Console.ReadKey(true);
    }
    private static uint Soma(uint num, uint num2)
    {
        return num + num2;
    }
}