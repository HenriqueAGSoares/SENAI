using System;

class Program
{
    static void Main()
    {
        Console.Write("CALCULADORA\nInsira o primeiro número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insira o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        char sinal;
        Console.Write("Insira o sinal da operação que você quer fazer com os números (+, -, * ou /): ");
        sinal = char.Parse(Console.ReadLine());
        while (sinal != '+' && sinal != '-' && sinal != '*' && sinal != '/')
        {
            Console.Write("Sinal inválido. Insira novamente: ");
            sinal = char.Parse(Console.ReadLine());

        }
        switch (sinal)
        {
            case '+':
                Console.WriteLine($"Soma: {num + num2}");
                break;
            case '-':
                Console.WriteLine($"Subtração: {num - num2}");
                break;
            case '*':
                Console.WriteLine($"Multiplicação: {num * num2}");
                break;
            case '/':
                Console.WriteLine($"Divisão: {num / num2}");
                break;
            default:
                Console.WriteLine("ERRO");
                break;
        }

        Console.ReadLine();
    }
}