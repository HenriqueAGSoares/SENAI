using System;

Console.Write("Você é um membro ativo do clube?\n---> ");
string eAtivo = Console.ReadLine().ToLower();
if (eAtivo == "sim")
    Console.WriteLine("Obrigado!");
else if (eAtivo == "não" || eAtivo == "nao")
    Console.WriteLine("Por favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube.");
else
    Console.WriteLine("Opção inválida.");

//byte querAcucarAdic = byte.Parse(Console.ReadLine());
//while (querAcucarAdic != 0 && querAcucarAdic != 1)
//{
//    Console.Write("Opção inválida.\nInsira '1' para SIM e '0' para NÃO: ");
//    querAcucarAdic = byte.Parse(Console.ReadLine());
//}

//bool querAdic = (querLeiteAdic == 1 || querAcucarAdic == 1) ? true : false;
//Console.WriteLine($"Café {((querAdic) ? "com adicional" : "sem adicional")} preparado!");

//Console.Write("Insira um número: ");
//byte num = byte.Parse(Console.ReadLine());
//bool divChec = (num % 3 == 0 || num % 5 == 0) ? true : false;
//Console.WriteLine($"{num} {(divChec ? "é" : "não é")} divisível por 3 ou 5.");

//Console.WriteLine("FIM. PRESSIONE QUALQUER TECLA PARA SAIR");
//Console.ReadKey(true);