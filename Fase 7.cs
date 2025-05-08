using System;

class Program
{
    static void Main()
    {
        byte i = 1;
        while (i <= 5)
        {
            Console.WriteLine($"Contagem: {i++}");
        }
        
        Console.ReadLine();
    }
}