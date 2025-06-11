using System;

//Console.Write("Tabuada do 5 até 10: ");
//for (byte i = 5; i <= 10; i++)
//    for (byte j = 1; j <= 10; j++)
//        Console.WriteLine($"{i} * {j} = {i * j}");

for (byte i = 5; i <= 10; i++)
{
    Console.WriteLine($"Tabuada do {i}:");
    for (byte j = 1; j <= 10; j++)
        Console.WriteLine($"{i} * {j} = {i * j}");
    Console.WriteLine();
}