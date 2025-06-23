using System;
using System.Collections.Generic;

class Principal
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(Elementos(["Carro", "Moto", "Baleiahaha"]));
        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA SAIR...\n");
        Console.ReadKey(true);
    }
    private static string Elementos(List<string> palavras)
    {
        string nova = "";
        for (byte i = 0; i < palavras.Count; i++)
            nova += palavras[i];
        return nova;
    }
}