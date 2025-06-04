using System;

Console.Write("Insira seu nome: ");
string nome = Console.ReadLine();

Console.Write("Insira sua idade: ");
byte idade = byte.Parse(Console.ReadLine());

Console.WriteLine($"Acesso {((nome.Length < 3 || idade < 18) ? "negado" : "permitido")}.");

Console.WriteLine("FIM. PRESSIONE QUALQUER TECLA PARA SAIR");
Console.ReadKey(true);