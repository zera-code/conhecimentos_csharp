﻿using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitario;

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Console.WriteLine("Boas Vundas ao ByteBank: Administração");

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Miguel";
pedro.Cpf = "12334566";
pedro.Salario = 2000;


Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "9999999999";
paula.Salario = 5000;


Funcionario andre = new Diretor();
andre.Nome = "André";
andre.Cpf = "9999976565";
andre.Salario = 100;

Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.WriteLine("Bonificação: " + paula.getBonificacao());

gerenciador.Registrar(pedro);

gerenciador.Registrar(paula);

Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());


Console.ReadKey();
