using System;

Console.Write("Você deseja comprar um carro novo?\n'1' para SIM e '0' para NÃO: ");
byte querCarro = byte.Parse(Console.ReadLine());
while (querCarro != 0 && querCarro != 1)
{
    Console.Write("Opção inválida.\nInsira '1' para SIM e '0' para NÃO: ");
    querCarro = byte.Parse(Console.ReadLine());
}

Console.Write("O carro custa 100.000.\nVocê tem dinheiro suficiente?\n'1' para SIM e '0' para NÃO: ");
byte temDinheiro = byte.Parse(Console.ReadLine());
while (temDinheiro != 0 && temDinheiro != 1)
{
    Console.Write("Opção inválida.\nInsira '1' para SIM e '0' para NÃO: ");
    temDinheiro = byte.Parse(Console.ReadLine());
}

bool pode = (querCarro == 1 && temDinheiro == 1) ? true : false;
Console.WriteLine($"Você {((pode) ? "pode" : "não pode")} comprar um carro novo.");

Console.WriteLine("FIM. PRESSIONE QUALQUER TECLA PARA SAIR");
Console.ReadKey(true);