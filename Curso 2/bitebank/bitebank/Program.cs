using bytebank;


Console.WriteLine("Seja bem vindo ao seu banco: ByteBank!");


ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Arthur Silva";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

/*
ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Silva";
conta2.conta = "111999-X";
conta2.numero_agencia = 58;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;


Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número Agência: " + conta1.numero_agencia);
Console.WriteLine("Nome da Agência: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo); */

double saldo = 100;
double saldo2 = conta1.saldo;
conta1.saldo = 200;


Console.WriteLine(saldo == conta1.saldo);
Console.WriteLine(saldo == saldo2);


Console.ReadKey();
