using System;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Projeto 4 - Conversões e outros tipos");
        double salario;
        salario = 3000.15;

        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        // O long é um tipo de variável de 64 bits
        long x;
        x = 2000000000000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);

        int idade = 3 * 10;
        Console.WriteLine(idade);


        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
