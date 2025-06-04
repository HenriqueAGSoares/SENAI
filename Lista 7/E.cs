using System;

int num, resultado = 0;
do
{
    Console.Write("Insira um número positivo, ou algum negativo para encerrar (APENAS NÚMEROS): ");
    num = int.Parse(Console.ReadLine());
    if (num > 0)
        resultado += num;
} while (num > 0);
Console.WriteLine("Você inseriu um número negativo. Fim do programa.");
Console.WriteLine($"A soma dos números inseridos é {resultado}.");