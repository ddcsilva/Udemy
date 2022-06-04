using System.Globalization;

namespace Exercicio01
{
    internal class ContaCorrente
    {
        private string _nomeTitular;

        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaCorrente(int numeroConta, string nomeTitulo)
        {
            NumeroConta = numeroConta;
            _nomeTitular = nomeTitulo;
            Saldo = 0;
        }

        public ContaCorrente(int numeroConta, string nomeTitulo, double saldoInicial) : this(numeroConta, nomeTitulo)
        {
            Saldo = saldoInicial;
        }

        public string NomeTitular
        {
            get { return _nomeTitular; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _nomeTitular = value;
                }
            }
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0)
            {
                Saldo -= (valor + 5.00); 
            }
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta + ", Titular: " + NomeTitular + ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
