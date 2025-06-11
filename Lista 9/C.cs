using System;

//float[] valores = {3.2f, 4.5f, 5.1f};
float[] valores = {3f, 3f, 3f};
float media = 0;

Console.Write("A média de ");
for (byte i = 0; i < 3; i++)
{
    media += valores[i];
    Console.Write($"{(i < 2 ? $"{valores[i]}, " : $"{valores[i]} é: ")}");
}
Console.WriteLine($"{(float)(media / valores.Length):F2}");