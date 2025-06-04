using System;

Console.Write("Insira um número: ");
byte? num = byte.Parse(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("Isso corresponde a um domingo."); break;
    case 2:
        Console.WriteLine("Isso corresponde a uma segunda-feira."); break;
    case 3:
        Console.WriteLine("Isso corresponde a uma terça-feira."); break;
    case 4:
        Console.WriteLine("Isso corresponde a uma quarta-feira."); break;
    case 5:
        Console.WriteLine("Isso corresponde a uma quinta-feira."); break;
    case 6:
        Console.WriteLine("Isso corresponde a uma sexta-feira."); break;
    case 7:
        Console.WriteLine("Isso corresponde a um sábado."); break;
    default:
        Console.WriteLine("Seu número não corresponde à nenhum dia da semana."); break;
}