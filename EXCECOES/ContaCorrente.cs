using System;

namespace EXCECOES
{
    public class ContaCorrente
    {


        public static double TaxaOperacao;

        public static int TotalContasCriadas { get; private set; }

        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }

        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public int Numero { get; }

        public int Agencia { get; }

        private double _saldo;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;

                }

                _saldo = value;

            }
        }

        public ContaCorrente(Cliente titular, int numeroAgencia, int numeroConta)
        {

            if (titular == null)
            {
                throw new NullReferenceException("O titular não pode ser nulo!");
            }

            if (numeroAgencia <= 0)
            {
                throw new ArgumentException("A agencia não pode ser maior que 0!", nameof(numeroAgencia));
            }

            if (numeroConta <= 0)
            {
                throw new ArgumentException("O número não pode ser maior que 0!", nameof(numeroConta));
            }



            Titular = titular;
            Agencia = numeroAgencia;
            Numero = numeroConta;

            TotalContasCriadas++;
            TaxaOperacao = 30 / TotalContasCriadas;



        }



        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                ContadorSaquesNaoPermitidos++;
                throw new ArgumentException("Valor invalido para o saque", nameof(valor));
            }

            if (_saldo < valor)
            {

                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;


        }

        public void Depositar(double valor)
        {
            _saldo += valor;

        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para uma transferencia", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException();
            }


            contaDestino.Depositar(valor);


        }
    }
}
