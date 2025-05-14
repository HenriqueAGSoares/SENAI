using System;

struct Program
{
    static void Main()
    {
        ChecarDoisNums(); //EXERCÍCIOS a, b E c
        Console.WriteLine("====================================================");
        ChecarTresNums(); //EXERCÍCIO d
        Console.WriteLine("====================================================");
        ChecarDoubles(); //EXERCÍCIOS e, E g
        Console.WriteLine("====================================================");
        ImparOuPar(); //EXERCÍCIO f
        Console.WriteLine("====================================================");
        NumPosOuNeg(); //EXERCÍCIO h
        Console.WriteLine("====================================================");
        Diferenca(); //EXERCÍCIO i
        Console.WriteLine("====================================================");
        DoubleEIgualAZero(); //EXERCÍCIO j
        Console.WriteLine("====================================================");



        Console.WriteLine("PRESSIONE QUALQUER TECLA PARA SAIR");
        Console.ReadKey(true);
    }
    static void ChecarDoisNums() //EXERCÍCIOS a, b E c
    {
        Console.Write("\n*QUAL NÚMERO É O MAIOR*\nInsira o primeiro número: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insira o segundo número: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((a > b) ? $"{a} é maior que {b}." : (a == b) ? "Os números são iguais." : $"{a} é menor que {b}.");
        //Console.WriteLine($"{((a > b) ? a : b)} é maior.");
        Console.WriteLine();
    }
    static void ChecarTresNums() //EXERCÍCIO d
    {
        Console.Write("\nInsira o primeiro número: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Terceiro número: ");
        int c = int.Parse(Console.ReadLine());


        Console.Write("O PRIMEIRO NÚMERO É MENOR QUE O SEGUNDO E MAIOR QUE O TERCEIRO? ");
        Console.WriteLine((a < b && a > c) ? "SIM" : "NÃO");
        Console.WriteLine();
    }
    static void ChecarDoubles() //EXERCÍCIOS e, E g
    {
        Console.WriteLine("Insira dois números REAIS...");
        Console.Write("Primeiro: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Segundo: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine((a > b) ? $"{a} é maior que {b}." : (a == b) ? $"{a} é igual a {b}." : $"{a} é menor que {b}.");
    }
    static void ImparOuPar() //EXERCÍCIO f
    {
        Console.WriteLine("*É PAR OU ÍMPAR?*");
        Console.Write("Insira um número: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"{num} é {((num % 2 == 0) ? "par." : "ímpar.")}");
    }
    static void NumPosOuNeg() //EXERCÍCIO h
    {
        Console.WriteLine("*NÚMERO POSITIVO OU NEGATIVO?*");
        Console.Write("Insira um número: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"{num} é {((num < 0) ? "negativo." : "positivo.")}");
    }
    static void Diferenca() //EXERCÍCIO i
    {
        Console.WriteLine("*DIFERENÇA ENTRE NÚMEROS É MENOR OU IGUAL A 10?*");
        Console.Write("Insira o minuendo: ");
        int minu = int.Parse(Console.ReadLine());
        Console.Write("Insira o subtraendo: ");
        int subt = int.Parse(Console.ReadLine());
        Console.WriteLine($"A diferença entre {minu} e {subt} ({minu - subt}) {((minu - subt < 10) ? "é menor que 10." : ((minu - subt) == 10) ? "é igual a 10." : "é maior que 10.")}");
    }
    static void DoubleEIgualAZero() //EXERCÍCIO j
    {
        Console.WriteLine("*NÚMERO DECIMAL É IGUAL A ZERO?*");
        Console.Write("Insira um número decimal: ");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine($"{num} é {((num == 0) ? "igual a zero." : "diferente de zero.")}");
    }
}