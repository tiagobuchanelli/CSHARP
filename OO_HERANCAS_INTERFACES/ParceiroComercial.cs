using System;
using OO_HERANCAS_INTERFACES.Sistemas;

namespace OO_HERANCAS_INTERFACES
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
