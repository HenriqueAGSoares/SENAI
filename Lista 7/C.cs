using System;

Console.WriteLine("Insira 5 números inteiros...");
uint[] nums = new uint[5];
uint i = 0, resultado = 0;
while (i < 5)
{
    Console.Write($"{i + 1}º número: ");
    nums[i] = uint.Parse(Console.ReadLine());
    ++i;
}
i = 0;
Console.Write($"{nums[0]} + {nums[1]} + {nums[2]} + {nums[3]} + {nums[4]} = ");
while (i < 5)
{
    resultado += nums[i];
    ++i;
}
Console.WriteLine(resultado);