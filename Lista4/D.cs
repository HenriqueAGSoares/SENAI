using System;

Console.Write("Você tem assinatura em serviços de streaming?\n'1' para SIM e '0' para NÃO: ");
byte temStreaming = byte.Parse(Console.ReadLine());
while (temStreaming != 0 && temStreaming != 1)
{
    Console.Write("Opção inválida.\nInsira '1' para SIM e '0' para NÃO: ");
    temStreaming = byte.Parse(Console.ReadLine());
}

Console.Write("Você já assistiu Arquivo X?\n'1' para SIM e '0' para NÃO: ");
byte assistiuSerie = byte.Parse(Console.ReadLine());
while (assistiuSerie != 0 && assistiuSerie != 1)
{
    Console.Write("Opção inválida.\nInsira '1' para SIM e '0' para NÃO: ");
    assistiuSerie = byte.Parse(Console.ReadLine());
}

bool seguirTemporada = (temStreaming == 1 && assistiuSerie == 1) ? true : false;
Console.WriteLine($"Você {((seguirTemporada) ? "já pode" : "não pode")} assistir à próxima temporada de Arquivo X.");

Console.WriteLine("FIM. PRESSIONE QUALQUER TECLA PARA SAIR");
Console.ReadKey(true);