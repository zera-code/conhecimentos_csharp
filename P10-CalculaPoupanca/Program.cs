﻿using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula poupança");

        double investimento = 1000;
        // rendimentyo de 0.5% (0.005) ao mês


        //mês 1
        //investimento = investimento + investimento * 0.005;
        //mês 2
        //investimento = investimento + investimento * 0.005;
        //mês 3
        //investimento = investimento + investimento * 0.005;

        Console.WriteLine(investimento); 

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você terá R$ " + investimento);

            //mes = mes +1; formas de somar mais 1
            //mes ++
            mes += 1;
        }




        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
