using System;

namespace Exercicios
{
    class Principal
    {
        static void Main()
        {
            string?[] endereco = new string[5];
            Console.WriteLine("Insira seu endereço completo abaixo.");
            for (short i = 0; i <= 5; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("Nome da rua: ");
                        endereco[i] = Console.ReadLine();
                        break;
                    case 1:
                        Console.Write("Nome do bairro: ");
                        endereco[i] = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Número da casa: ");
                        endereco[i] = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Cidade: ");
                        endereco[i] = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Estado: ");
                        endereco[i] = Console.ReadLine();
                        break;
                    default: break;
                }
            }
            Console.WriteLine("\nSeu endereço:\nRua: " + endereco[0] + "\nBairro: " + endereco[1] + "\nNúmero: " +
                endereco[2] + "\nCidade: " + endereco[3] + "\nEstado: " + endereco[4] + ".");
        }
    }
}