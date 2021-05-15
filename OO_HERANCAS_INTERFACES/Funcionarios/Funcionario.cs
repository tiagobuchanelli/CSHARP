using System;
namespace OO_HERANCAS_INTERFACES.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }


        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;


            TotalDeFuncionarios++;
            //Console.WriteLine("Criando Funcionario");
        }


        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
