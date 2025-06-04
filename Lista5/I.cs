using System;

Console.Write("Insira um número: ");
byte num = byte.Parse(Console.ReadLine());
Console.Write("Insira outro número: ");
byte num2 = byte.Parse(Console.ReadLine());
Console.WriteLine($"{num} {(num % num2 == 0 ? "é" : "não é")} divisível por {num2}.");