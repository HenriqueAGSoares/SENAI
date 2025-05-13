using System;

Console.Write("Insira o primeiro número: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o segundo número: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A SOMA desses números é {a + b}.");

Console.WriteLine("PRESSIONE QUALQUER TECLA PARA SAIR");
Console.ReadKey(true);