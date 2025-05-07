using System;
using System.Globalization;

namespace Exercicios
{
    class Principal
    {
        static void Main()
        {
            Console.Write("Insira seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Insira sua idade: ");
            short idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Nome: " + nome + ".\nIdade: " + idade + ".");
        }
    }
}