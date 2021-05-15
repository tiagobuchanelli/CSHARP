using System;
using OO_HERANCAS_INTERFACES.Funcionarios;

namespace OO_HERANCAS_INTERFACES
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }


        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
