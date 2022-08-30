using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executanto o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 1;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado, pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
