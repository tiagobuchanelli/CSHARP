using System;
using OO_HERANCAS_INTERFACES.Funcionarios;
using OO_HERANCAS_INTERFACES.Sistemas;

namespace OO_HERANCAS_INTERFACES
{
    class Program
    {
        static void Main(string[] args)
        {


            CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }


        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();


            Diretor roberta = new Diretor(5000, "125.985.745-98");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta(4000, "123.633.555-98");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123";


            sistema.Logar(roberta, "123");
            sistema.Logar(camila, "abc");
            sistema.Logar(parceiro, "123");


        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer(3000, "126.123.123.58");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor(5000, "125.985.745-98");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar(2000, "744.999.888-65");
            igor.Nome = "Igor";


            GerenteDeConta camila = new GerenteDeConta(4000, "123.633.555-98");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor(3000, "451.658.989-98");
            guilherme.Nome = "Guilherme";




            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de bonificações do mes " +
                gerenciador.GetTotalBonificacao());

        }
    }
}
