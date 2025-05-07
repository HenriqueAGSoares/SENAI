using System;
using System.Globalization;

namespace Exercicios
{
    class Principal
    {
        static void Main()
        {
            Console.Write("Insira \"sim\" ou \"não\": ");
            string input = Console.ReadLine();
            //bool simOuNao = (input == "sim") ? true : false;
            bool simOuNao = input switch
            {
                "sim" => true,
                _ => false
            };
            Console.WriteLine("Resultado: " + (simOuNao ? true : false));
        }
    }
}