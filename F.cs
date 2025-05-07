using System;
using System.Globalization;

namespace Exercicios
{
    class Principal
    {
        static void Main()
        {
            Console.Write("Insira um número decimal: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Você inseriu " + num + ".");
        }
    }
}