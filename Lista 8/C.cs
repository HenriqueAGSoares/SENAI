using System;

Console.Write("Insira uma palavra: ");
string palavra = Console.ReadLine();
char[] letras = new char[palavra.Length];
Console.WriteLine($"Letras da palavra '{palavra}', separadas: ");
for (ushort i = 0; i < letras.Length; i++)
{
    letras[i] = char.Parse(palavra.Substring(i, 1));
    Console.WriteLine(letras[i]);
}