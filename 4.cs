using System;

Console.Write("Insira um número: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Esse número elevado ao quadrado é {Math.Pow(a, 2)}.");

Console.WriteLine("PRESSIONE QUALQUER TECLA PARA SAIR");
Console.ReadKey(true);