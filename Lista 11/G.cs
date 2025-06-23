using System;

class Principal
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(StringImpar("cinco"));
        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA SAIR...\n");
        Console.ReadKey(true);
    }
    private static string StringImpar(string palavra)
    {
        string nova = "";
        for (ushort i = 0; i < palavra.Length; i += 2)
            nova += palavra.Substring(i, 1);
        return nova;
    }
}