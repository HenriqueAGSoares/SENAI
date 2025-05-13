using System;

Console.Write("Insira um número: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"O VALOR ABSOLUTO de {a} é {a:F0}");
//Console.WriteLine($"O VALOR ABSOLUTO de {a} é {(int) a}");
//Console.WriteLine($"O VALOR ABSOLUTO de {a} é {Math.Truncate(a)}");

Console.WriteLine("PRESSIONE QUALQUER TECLA PARA SAIR");
Console.ReadKey(true);