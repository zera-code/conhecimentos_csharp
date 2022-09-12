﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    internal class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base (cpf, 3000)
        {
            Console.WriteLine("criando um Desenvolvedor");
        }

        public override void aumentarSalario()
        {
            this.Salario *= 0.15;
        }

        public override double getBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
