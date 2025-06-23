using System;
using System.Collections.Generic;

class Principal
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine(Media([5, 5, 5, 5, 5]));
        Console.WriteLine("\nPRESSIONE QUALQUER TECLA PARA SAIR...\n");
        Console.ReadKey(true);
    }
    private static uint Media(List<uint> nums)
    {
        uint media = 0;
        for (byte i = 0; i < nums.Count; i++)
            media += nums[i];
        return (uint)(media / nums.Count);
    }
}