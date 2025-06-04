using System;

Console.Write("Escolha uma cor entre vermelho, azul e verde: ");
string? cor = Console.ReadLine().ToLower();
switch (cor)
{
    case "vermelho":
        Console.WriteLine("Você escolheu vermelho.");
        break;
    case "azul":
        Console.WriteLine("Você escolheu azul.");
        break;
    case "verde":
        Console.WriteLine("Você escolheu verde.");
        break;
    default:
        Console.Write("Cor dissimilar às das opções.");
        break;
}