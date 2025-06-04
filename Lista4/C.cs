using System;

Console.Write("Você tem um diploma de ensino superior?\n'1' para SIM e '0' para NÃO: ");
byte temSuperior = byte.Parse(Console.ReadLine());
while (temSuperior != 0 && temSuperior != 1)
{
    Console.Write("Opção inválida.\nInsira '1' para SIM e '0' para NÃO: ");
    temSuperior = byte.Parse(Console.ReadLine());
}

Console.Write("Você tem 21 anos ou mais?\n'1' para SIM e '0' para NÃO: ");
byte temIdade = byte.Parse(Console.ReadLine());
while (temIdade != 0 && temIdade != 1)
{
    Console.Write("Opção inválida.\nInsira '1' para SIM e '0' para NÃO: ");
    temIdade = byte.Parse(Console.ReadLine());
}

bool qualificado = (temSuperior == 1 && temIdade == 1) ? true : false;
Console.WriteLine($"Você {((qualificado) ? "está" : "não está")} qualificado para a vaga.");

Console.WriteLine("FIM. PRESSIONE QUALQUER TECLA PARA SAIR");
Console.ReadKey(true);