﻿using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceriaComercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Funcionario funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }

        public bool Logar(ParceiroComercial funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta");
                return false;
            }
        }
    }
}
