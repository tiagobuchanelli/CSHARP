using System;
using System.IO;

namespace EXCECOES
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch
            {

            }

            Console.ReadLine();


        }

        private static void CarregarContas()
        {

            using LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt");
            leitor.LerProximaLinha();


            /* --- old
            LeitorDeArquivo leitor = null;
            try
            {
                leitor = new LeitorDeArquivo("contas.txt");

                leitor.LerProximaLinha();

            }
            
            finally
            {
                if (leitor != null)
                {
                    leitor.Fechar();
                }


            }*/
        }

        private static void TestarExcecoes()
        {
            try
            {
                Cliente joao = new Cliente();
                joao.Nome = "João";
                ContaCorrente conta = new ContaCorrente(joao, 20, 540);
                conta.Depositar(500);
                conta.Sacar(100);

                Cliente maria = new Cliente();
                joao.Nome = "Maria";
                ContaCorrente conta2 = new ContaCorrente(maria, 30, 600);
                conta2.Depositar(300);
                conta2.Transferir(1000, conta);

            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argumento com problema: " + e.ParamName);
                Console.WriteLine(e.Message);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);

            }
        }
    }
}
