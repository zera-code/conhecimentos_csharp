using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.ParceriaComercial
{
    public class ParceiroComercial : Autenticavel
    {
        public ParceiroComercial(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }

        public override void aumentarSalario()
        {
            throw new NotImplementedException();
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

        public override double getBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
