using System;

Console.Write("Insira um número: ");
int? num = int.Parse(Console.ReadLine());
switch (num)
{
    case 0:
        Console.WriteLine("O número é zero.");
        break;
    case > 0:
        Console.WriteLine("O número é positivo.");
        break;
    case < 0:
        Console.WriteLine("O número é negativo.");
        break;
    default:
        Console.Write("ERRO INESPERADO");
        break;
}