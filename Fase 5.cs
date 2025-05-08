using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua idade: ");
        short idade = short.Parse(Console.ReadLine());
        //short idade = Convert.ToInt16(Console.ReadLine());
        if (idade >= 18)
            Console.WriteLine("Você é maior de idade.");
        else Console.WriteLine("Você é menor de idade.");
        //Com op. ternário, abaixo
        //Console.WriteLine((idade >= 18) ? "Você é maior de idade." : "Você é menor de idade.");
        
        Console.ReadLine();
    }
}