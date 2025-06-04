using System;

//struct Program
//{

//}

Console.Write("Você tem mais de 18 anos?\n--> ");
string input = Console.ReadLine();
bool eMaior;
while (true)
{
    switch (input)
    {
        case "sim":
            eMaior = true; break;
        case "não": case "nao":
            eMaior = false; break;
        default:
            Console.Write("Input inválido. Insira \"sim\" ou \"não\".\n--> ");
            input = Console.ReadLine();
            continue;
    }
    break;
}
Console.Write("Você tem carteira de habilitação?\n--> ");
input = Console.ReadLine();
bool temCNH;
while (true)
{
    switch (input)
    {
        case "sim":
            temCNH = true; break;
        case "não": case "nao":
            temCNH = false; break;
        default:
            Console.Write("Input inválido. Insira \"sim\" ou \"não\".\n--> ");
            input = Console.ReadLine();
            continue;
    }
    break;
}
Console.WriteLine();
Console.WriteLine((eMaior && temCNH) ? "Você pode dirigir." : (!eMaior && !temCNH) ? "Você não pode dirigir porque é menor e não tem CNH." :
    $"Você não pode dirigir porque {((!eMaior) ? "é menor de idade" : (!temCNH) ? "não tem habilitação" : null)}.");

Console.ReadKey(true);