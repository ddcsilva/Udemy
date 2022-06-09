namespace Aula04ClassesMetodosSelados.Entities
{
    // Classe não pode ser mais Herdada
    public sealed class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca()
        {

        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        // Não pode ser sobrescrita novamente
        public sealed override void Sacar(double quantia)
        {
            base.Sacar(quantia);
            Saldo -= 2.0;
        }
    }
}
