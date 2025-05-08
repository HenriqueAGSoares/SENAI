using System;

class Program
{
    static string? senha = "banana", input;
    static void Main()
    {
        Console.Write("Digite a senha: ");
        input = Console.ReadLine();
        Console.WriteLine((senha.Equals(input)) ? "Acesso garantido." : repetirSenha());

        Console.ReadLine();
    }
    static String repetirSenha()
    {
        while (senha != input)
        {
            Console.Write("Acesso negado. Tente novamente: ");
            input = Console.ReadLine();
        }
        return "Acesso garantido.";
    }
}