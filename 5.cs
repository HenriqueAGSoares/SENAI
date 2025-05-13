using System;

Console.Write("Insira um número: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira outro número: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a} dividido por {b} é {(double)a / b:F2}.");

Console.WriteLine("PRESSIONE QUALQUER TECLA PARA SAIR");
Console.ReadKey(true);