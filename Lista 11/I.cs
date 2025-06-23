using System;

class Principal
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(EPrimo(33));
        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA SAIR...\n");
        Console.ReadKey(true);
    }
    private static bool EPrimo(uint num)
    {
        for (byte i = 2; i < num; i++)
            if (num % i == 0)
                return false;
        return true;
    }
}