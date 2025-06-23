using System;
using System.Collections.Generic;

class Principal
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(CharCont("palavra"));
	Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA SAIR...\n");
	Console.ReadKey(true);
    }
    private static ushort CharCont(string palavra)
    {
        return (ushort)(palavra.Length);
    }
}