using System;

Console.Write("Insira um número: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira outro número: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A SUBTRAÇÃO de {a} por {b} resulta em {a - b}");

Console.WriteLine("PRESSIONE QUALQUER TECLA PARA SAIR");
Console.ReadKey(true);