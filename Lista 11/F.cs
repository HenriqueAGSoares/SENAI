using System;

class Principal
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(ENumPar(5));
        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA SAIR...\n");
        Console.ReadKey(true);
    }
    private static bool ENumPar(uint num)
    {
        return (num % 2 == 0);
    }
}