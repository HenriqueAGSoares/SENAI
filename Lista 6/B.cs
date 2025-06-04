using System;

DateTime dataTempoAtual = DateTime.Now;
DateTime dataPassada = new DateTime(2025, 05, 16);
TimeSpan diferenca = dataTempoAtual - dataPassada;
Console.WriteLine($"Diferença de dias entre hoje e 16/05/2025: {diferenca.Days}.");