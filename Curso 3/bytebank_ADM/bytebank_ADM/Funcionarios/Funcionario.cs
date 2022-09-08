﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public double Salario { get; set; }

        public virtual double getBonificacao()
        {
            return Salario * 0.10;
        }

        public static int totalDeFuncionarios { get; private set; }

        public Funcionario()
        {
            Console.WriteLine("Criando um funcionario");
            totalDeFuncionarios++;
        }

    }
}
