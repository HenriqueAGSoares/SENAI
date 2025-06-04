using System;
using System.Collections.Generic;

List<byte> nums = new List<byte>();
byte numsTamanho = 0;
//nums.Add(1);
//nums.Add(2);
//nums.Add(3);
for (byte i = 0; i < nums.Count; i++)
    numsTamanho += i;
Console.WriteLine($"A lista {(numsTamanho > 0 ? "não está" : "está")} vazia.");

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