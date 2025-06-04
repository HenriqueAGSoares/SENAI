using System;

Console.Write("Insira uma opção de 1 a 3: ");
sbyte? opt;
do
{
    opt = sbyte.Parse(Console.ReadLine());
    switch (opt)
    {
        case 1:
            Console.WriteLine("Você escolheu 1.");
            break;
        case 2:
            Console.WriteLine("Você escolheu 2.");
            break;
        case 3:
            Console.WriteLine("Você escolheu 3.");
            break;
        default:
            Console.Write("Opção inválida. Tente novamente: ");
            break;
    }
} while (opt < 1 || opt > 3);