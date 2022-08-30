using bytebank;

Console.WriteLine("Seja bem vindo ao seu banco: ByteBank!");


ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Arthur Silva";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número Agência: " + conta1.numero_agencia);
Console.WriteLine("Nome da Agência: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);
