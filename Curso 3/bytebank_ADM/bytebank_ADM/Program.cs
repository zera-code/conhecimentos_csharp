using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Console.WriteLine("Boas Vundas ao ByteBank: Administração");

Funcionario pedro = new Funcionario("12334566");
pedro.Nome = "Pedro Miguel";
pedro.Salario = 2000;
Console.WriteLine("Total de funcionarios: " + Funcionario.totalDeFuncionarios);


Diretor paula = new Diretor("9999999999");
paula.Nome = "Paula";
paula.Salario = 5000;
Console.WriteLine("Total de funcionarios: " + Funcionario.totalDeFuncionarios);


Funcionario andre = new Diretor("9999976565");
andre.Nome = "André";

andre.Salario = 100;
Console.WriteLine("Total de funcionarios: " + Funcionario.totalDeFuncionarios);

Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.WriteLine("Bonificação: " + paula.getBonificacao());

gerenciador.Registrar(pedro);

gerenciador.Registrar(paula);


Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());
andre.aumentarSalario();
pedro.aumentarSalario();
Console.WriteLine("Novo salário do André: " + andre.Salario);
Console.WriteLine("Novo salário do André: " + pedro.Salario);


Console.ReadKey();

