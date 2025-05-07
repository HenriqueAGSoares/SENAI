using System;

namespace Exercicios
{
    class Principal
    {
        static void Main()
        {
            Console.Write("Insira um número real (float): ");
            float num = (float) Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Você inseriu " + num + ".");
        }
    }
}