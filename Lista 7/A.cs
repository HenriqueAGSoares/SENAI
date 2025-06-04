using System;

Console.Write("Insira um número inteiro: ");
uint num = uint.Parse(Console.ReadLine()), i = 0;
Console.WriteLine($"* LISTA DOS NÚMEROS PARES ENTRE ZERO E {num} *");
while (i <= num)
{
    if (i + 2 > num)
        break;
    else i += 2;
    Console.WriteLine(i);
}
