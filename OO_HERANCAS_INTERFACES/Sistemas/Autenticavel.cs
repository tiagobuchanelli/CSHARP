using System;
using OO_HERANCAS_INTERFACES.Funcionarios;

namespace OO_HERANCAS_INTERFACES.Sistemas
{
    public interface IAutenticavel
    {

        public bool Autenticar(string senha);
    }
}