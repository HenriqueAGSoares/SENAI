using System;

Console.WriteLine("Números primos de 1 a 100:\n1\n2");
bool primo = false;
for (byte i = 3; i <= 100; i++)
{
    for (byte j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            primo = false;
            break;
        }
        else primo = true;
    }
    if (primo)
        Console.WriteLine(i);
}