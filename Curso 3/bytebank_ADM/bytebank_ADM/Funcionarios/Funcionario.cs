using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }

        public string Cpf { get; private   set; }

        public double Salario { get; protected set; }

        public abstract double getBonificacao();

        public static int totalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            Console.WriteLine("Criando um funcionario");
            totalDeFuncionarios++;
        }

        public abstract void aumentarSalario();

    }
}
