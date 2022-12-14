using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("criando um Gerente de Contas");
        }

        public override double getBonificacao()
        {
            return Salario *=0.25;
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}
