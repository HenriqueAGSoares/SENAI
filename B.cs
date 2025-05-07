using System;

namespace Exercicios
{
    class Principal
    {
        static void Main()
        {
            Console.Write("Insira um número real: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Você inseriu " + num + ".");
        }
    }
}