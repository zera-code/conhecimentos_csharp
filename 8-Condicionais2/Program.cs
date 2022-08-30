using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executanto o projeto 8 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;


        if (idadeJoao >= 18 || grupo)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }


     //   if (idadeJoao >= 18 && quantidadePessoas > 1)
     //   {
     //       Console.WriteLine("Pode entrar!");
     //   }
     //   else
     //   {
     //       Console.WriteLine("Não pode entrar!");
     //   }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
