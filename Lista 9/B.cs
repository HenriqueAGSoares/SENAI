using System;

string[,] dados = new string[5, 3];
float[] media = new float[5];

for (byte i = 0; i < 5; i++)
{
    for (byte j = 0; j < 3; j++)
    {
        Console.Write($"Insira {(j == 0 ? "o nome" : $"a {j}ª nota")} do {i + 1}º aluno: ");
        dados[i, j] = Console.ReadLine();
    }
    Console.WriteLine();
    media[i] = (float)((float.Parse(dados[i, 1]) + float.Parse(dados[i, 2])) / 2);
}
for (byte i = 0; i < 5; i++)
    Console.WriteLine($"Nome do aluno: {dados[i, 0]} | 1ª nota: {dados[i, 1]} | 2ª nota: {dados[i, 2]} | Média das notas: {media[i]}.");