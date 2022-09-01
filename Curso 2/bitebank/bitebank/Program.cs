using bytebank;
using bytebank;
using bytebank.Titular;

Console.WriteLine("Seja bem vindo ao seu banco: ByteBank!");

/*
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

Cliente cliente = new Cliente();
cliente.nome = "André Silva";
cliente.cpf = "12334455667";
cliente.profissao = "programador c#";


Console.WriteLine("Saldo da Amanda pré-transferência: " + conta2.saldo);
Console.WriteLine("Saldo do André pré-transferência: " + conta1.saldo);

bool transferencia = conta1.Transferir(50, conta2);

Console.WriteLine("Transferência realizada com sucesso? " + transferencia);
Console.WriteLine("Saldo da Amanda pós-transferência: " + conta2.saldo);
Console.WriteLine("Saldo do André pós-transferência: " + conta1.saldo);
*/

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "12334455667";
//cliente.profissao = "programador c#";

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = new Cliente();
//conta3.conta = "2512352-X";
//conta3.numero_agencia = 35;
//conta3.nome_agencia = "Agencia Central";
//conta3.titular.nome = "André Silva";
//conta3.titular.profissao = "Programador C#";
//conta3.titular.cpf = "123456789";

//Console.WriteLine(conta3.titular.nome);
//Console.WriteLine(conta3.titular.nome);

//if (conta3.titular == null)
//{
//    Console.WriteLine("O titular está nulo");
//}


ContaCorrente conta4 = new ContaCorrente();
conta4.saldo = -10;
Console.WriteLine(conta4.saldo);

Console.ReadKey();
