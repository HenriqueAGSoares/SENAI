using System;
using System.Globalization;

namespace Exercicios
{
    class Principal
    {
        static void Main()
        {
            Console.Write("Insira um caractere: ");
            char caractere = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Você inseriu um " + caractere + ".");
        }
    }
}