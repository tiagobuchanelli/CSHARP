using System;
using OO_HERANCAS_INTERFACES.Sistemas;

namespace OO_HERANCAS_INTERFACES.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(double salario, string cpf) : base(salario, cpf)
        {
            //Console.WriteLine("Criando diretor");
        }

        public override void AumentarSalario()
        {
            Salario *= 0.11;
        }

        public override double GetBonificacao()
        {

            return Salario * 0.17;
        }
    }

}
