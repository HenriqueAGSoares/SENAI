using System;
using System.Globalization;

namespace Exercicios
{
    class Principal
    {
        static void Main()
        {
            Console.Write("Insira o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insira a porcentagem de desconto: ");
            double desconto = Convert.ToDouble(Console.ReadLine());
            desconto = desconto switch
            {
                > 100 => 100,
                < 0 => 0,
                _ => desconto
            };
            Console.WriteLine("Preço final com " + desconto + "% de desconto: " + preco * (desconto / 100));
        }
    }
}