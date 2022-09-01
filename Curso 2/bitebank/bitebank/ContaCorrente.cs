﻿using bytebank;
using bytebank.Titular;

namespace bytebank
{
    public class  ContaCorrente
    {
        public Cliente Titular { get; set; }

        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        private int _numero_agencia;
        public int Numero_agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {
                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        public string Nome_agencia { get; set; }

        private double saldo;


        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }


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


        //public void SetSaldo(double valor)
        //{
        //    if (valor < 0)
        //    {
        //        return;
        //    }
        //    saldo = valor;
        //}

        //public double GetSaldo ()
        //{
        //    return saldo;
        //}

        public ContaCorrente (int numero_agencia, string conta)
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
        }

    }
}
