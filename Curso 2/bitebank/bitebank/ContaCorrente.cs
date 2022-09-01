using bytebank;
using bytebank.Titular;

namespace bytebank
{
    public class  ContaCorrente
    {
        public Cliente titular;

        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;


        public bool Sacar(double valor)
        {
            if(saldo < valor)
                {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }


        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            saldo = saldo + valor;
        }


        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }


    }
}
