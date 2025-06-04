using System;

Console.Write("Insira uma letra: ");
char? letra = char.Parse(Console.ReadLine().ToLower());
switch (letra)
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("Você inseriu uma vogal.");
        break;
    default:
        Console.Write("Você inseriu uma consoante.");
        break;
}