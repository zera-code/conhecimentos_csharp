using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        // 0 - funcionário
        // 1 - diretor
        // 2 - designer
        // N - ...

        private int _tipo;

        public Funcionario(int _tipo)
        {
            this._tipo = _tipo;
        }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public double Salario { get; set; }

        public double getBonificacao()
        {
            if (_tipo == 1)
            {
                return Salario;
            }
            else
            {
                return Salario * 0.10;
            }
        }
    }
}
