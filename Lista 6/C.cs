using System;

DateTime dataTempoAtual = DateTime.Now;
DateTime dataNascimento = new DateTime(1967, 04, 26);
byte anosDeIdade = (byte) (dataTempoAtual.Year - dataNascimento.Year);
Console.WriteLine($"A pessoa que nasceu em {dataNascimento.ToString("dd/MM/yyyy")} tem {anosDeIdade} anos de idade.");