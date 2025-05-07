using System;
using System.Globalization;

namespace Exercicios
{
    class Principal
    {
        static void Main()
        {
            Console.Write("Insira uma palavra: ");
            string palavra = Console.ReadLine();
            short largura = Convert.ToInt16(palavra.Length);
            Console.WriteLine("Essa palavra tem " + largura + " caracteres.");
        }
    }
}