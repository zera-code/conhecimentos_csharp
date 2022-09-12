using bytebank_ADM.Funcionarios;
using bytebank_ADM.ParceriaComercial;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;


void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer pedro = new Designer("833.222.048-39");
    pedro.Nome = "Pedro";

    Desenvolvedor samya = new Desenvolvedor("354.869.002-11");
    samya.Nome = "Samya";

    Diretor paula = new Diretor("159.753.398-04");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("981.198.778-53");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("326.985.628-89");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(samya);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao());
}

//CalcularBonificacao();
UsarSistema();

void UsarSistema()
{
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor roberta = new Diretor("123.123.123.12");
    roberta.Nome = "Roberta";
    roberta.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("123.123.123.12");
    ursula.Nome = "Ursula";
    ursula.Senha = "321";

    //Designer pedro = new Designer("833.222.048-39");
    //pedro.Nome = "Pedro";
    //pedro.Senha = "123";


    ParceiroComercial joao = new ParceiroComercial();
    joao.Senha = "123";

    sistemainterno.Logar(roberta, "123");
    sistemainterno.Logar(ursula, "123");
    sistemainterno.Logar(joao, "123");
    //sistemainterno.Logar(pedro, "123");

}

Console.ReadKey();
