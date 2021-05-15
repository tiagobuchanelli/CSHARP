using System;
using OO_HERANCAS_INTERFACES.Sistemas;

namespace OO_HERANCAS_INTERFACES.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        public Diretor(double salario, string cpf) : base(salario, cpf)
        {
            //Console.WriteLine("Criando diretor");
        }



        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }



        public override double GetBonificacao()
        {

            return Salario * 0.5;
        }
    }
}
