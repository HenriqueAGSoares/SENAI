using System;

Console.Write("Insira um número inteiro positivo: ");
uint num = uint.Parse(Console.ReadLine());
bool ePrimo = num == 2;
for (uint i = 2; i < num; i++)
{
    if (num % i == 0)
        break;
    else ePrimo = true;
}
Console.Write($"O número {num} {(ePrimo ? "é" : "não é")} primo.");