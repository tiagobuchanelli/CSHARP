using System;
namespace OO_HERANCAS_INTERFACES.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(double salario, string cpf) : base(salario, cpf)
        {
            //Console.WriteLine("Criando diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.1;
        }

        public override double GetBonificacao()
        {

            return Salario * 0.2;
        }
    }

}
