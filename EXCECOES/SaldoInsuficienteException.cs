using System;
namespace EXCECOES
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSque { get; }

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de sque do valor de " + valorSaque + " em uma conta com saldo de " + saldo) //this chama o construtor da propria classe
        {
            Saldo = saldo;
            ValorSque = valorSaque;

        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
        }

        public SaldoInsuficienteException(string mensagem, Exception execaoInterna) : base(mensagem, execaoInterna)
        {
        }
    }
}
