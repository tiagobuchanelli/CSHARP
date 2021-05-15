using System;
namespace OO_HERANCAS_INTERFACES.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(double salario, string cpf) : base(salario, cpf)
        {
            //Console.WriteLine("Criando diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double GetBonificacao()
        {

            return Salario * 0.1;
        }

    }
}
