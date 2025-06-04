using System;

Console.Write("Insira um número inteiro positivo: ");
uint num = uint.Parse(Console.ReadLine());
byte i = 0;
Console.WriteLine($"Lista de números pares entre 0 e {num}:");
while (i < num)
{
    if (i + 2 > num)
        break;
    else i += 2;
    Console.WriteLine(i);
}