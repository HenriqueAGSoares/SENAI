using System;

Console.Write("Insira um número: ");
int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Insira o segundo número: ");
//int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"O DOBRO desse número é {a * 2}.");

Console.WriteLine("PRESSIONE QUALQUER TECLA PARA SAIR");
Console.ReadKey(true);