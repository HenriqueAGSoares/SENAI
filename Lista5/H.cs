using System;

Console.Write("Insira números: ");
string str = Console.ReadLine();
//bool convSucesso;
int strConv;
Console.WriteLine($"{(Int32.TryParse(str, out strConv) ? $"Você inseriu {strConv}." : "Conversão impossível.")}");