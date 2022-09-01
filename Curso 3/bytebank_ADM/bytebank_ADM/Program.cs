using bytebank_ADM.Funcionarios;

Console.WriteLine("Boas Vundas ao ByteBank: Administração");

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Miguel";
pedro.Cpf = "12334566";
pedro.Salario = 2000;

Console.WriteLine("Nome: " + pedro.Nome);
Console.WriteLine("CPF: " + pedro.Cpf);
Console.WriteLine("Salário: " + pedro.Salario);


Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "9999999999";
paula.Salario = 5000;

Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.WriteLine("Bonificação: " + paula.getBonificacao());

Console.ReadKey();

