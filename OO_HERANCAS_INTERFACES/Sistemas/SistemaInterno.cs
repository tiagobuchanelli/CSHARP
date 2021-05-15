using System;
using OO_HERANCAS_INTERFACES.Funcionarios;

namespace OO_HERANCAS_INTERFACES.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel autenticavel, string senha)
        {
            bool usuarioAutenticado = autenticavel.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem Vindo ao sistema...");
                return true;
            }
            else
            {
                Console.WriteLine("Voce não se autenticou");
                return false;
            }

        }
    }
}
