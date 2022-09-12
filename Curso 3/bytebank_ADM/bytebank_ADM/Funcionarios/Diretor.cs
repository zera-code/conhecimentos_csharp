﻿using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public Diretor(string cpf):base(cpf, 5000)
        {
            Console.WriteLine("criando um Diretor");
        }

        public override double getBonificacao()
        {
            return Salario *= 0.5;
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.15;
        }

      /*  public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        } */
    }
}
