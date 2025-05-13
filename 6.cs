using System;

Console.Write("Insira um número: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A raíz quadrada de {a} é ");
Console.WriteLine((Math.Sqrt(a) % 1 == 0) ? Math.Sqrt(a) : $"{(double) Math.Sqrt(a):F2}");

Console.WriteLine("PRESSIONE QUALQUER TECLA PARA SAIR");
Console.ReadKey(true);