using System;

Console.Write("Soma dos números pares de 1 a 100: ");
ushort resultado = 0;
for (byte i = 2; i <= 100; i += 2)
    resultado += i;
Console.WriteLine(resultado);