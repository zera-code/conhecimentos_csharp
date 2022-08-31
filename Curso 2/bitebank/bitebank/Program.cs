using bytebank;


Console.WriteLine("Seja bem vindo ao seu banco: ByteBank!");


ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Andre Silva";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;


ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Andre Silva";
conta2.conta = "10123-X";
conta2.numero_agencia = 23;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;


Console.WriteLine("Saldo da Amanda pré-saque: " + conta2.saldo);

bool saque = conta2.Sacar(50);

Console.WriteLine("Saque realizado? " + saque);

Console.WriteLine("Saldo da Amanda pós-saque: " + conta2.saldo);

//bool depositar = conta2.Depositar(60);

Console.WriteLine("Saldo da Amanda pós-depósito: " + conta2.saldo);


Console.ReadKey();
