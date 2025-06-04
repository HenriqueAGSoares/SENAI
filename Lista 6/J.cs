using System;

Console.Write("Insira um tamanho de camisa (P, M ou G): ");
char? num = char.Parse(Console.ReadLine().ToUpper());
switch (num)
{
    case 'P':
        Console.WriteLine("O preço de uma camisa tamanho P é R$40."); break;
    case 'M':
        Console.WriteLine("O preço de uma camisa tamanho M é R$69."); break;
    case 'G':
        Console.WriteLine("O preço de uma camisa tamanho G é R$89."); break;
    default:
        Console.WriteLine("Opção dissimilante."); break;
}