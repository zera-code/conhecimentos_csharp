using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Console.WriteLine("Boas Vundas ao ByteBank: Administração");

Funcionario pedro = new Funcionario("12334566", 1000);
pedro.Nome = "Pedro Miguel";
Console.WriteLine("Total de funcionarios: " + Funcionario.totalDeFuncionarios);


Diretor paula = new Diretor("9999999999", 5000);
paula.Nome = "Paula";
Console.WriteLine("Total de funcionarios: " + Funcionario.totalDeFuncionarios);


Funcionario andre = new Diretor("9999976565", 4000);
andre.Nome = "André";

Console.WriteLine("Total de funcionarios: " + Funcionario.totalDeFuncionarios);

Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.WriteLine("Bonificação: " + paula.getBonificacao());

gerenciador.Registrar(pedro);

gerenciador.Registrar(paula);


Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());
andre.aumentarSalario();
pedro.aumentarSalario();
paula.aumentarSalario();
Console.WriteLine("Novo salário do André: " + andre.Salario);
Console.WriteLine("Novo salário do André: " + pedro.Salario);


Console.ReadKey();
