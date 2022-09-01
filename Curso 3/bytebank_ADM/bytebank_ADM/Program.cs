using bytebank_ADM.Funcionarios;

Console.WriteLine("Boas Vundas ao ByteBank: Administração");

Funcionario pedro = new Funcionario(1);
pedro.Nome = "Pedro Miguel";
pedro.Cpf = "12334566";
pedro.Salario = 2000;

Console.WriteLine("Nome: " + pedro.Nome);
Console.WriteLine("CPF: " + pedro.Cpf);
Console.WriteLine("Salário: " + pedro.Salario);

Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.ReadKey();

