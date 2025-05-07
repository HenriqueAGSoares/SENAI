using System;

namespace Exercicios
{
    class Principal
    {
        static void Main()
        {
            Console.Write("Insira um número inteiro: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Você inseriu " + num + ".");
        }
    }
}