namespace Aula01Heranca.Entities
{
    public class Conta
    {
        public int Numero { get; protected set; }
        public string Titular { get; protected set; }
        public double Saldo { get; protected set; }

        public Conta()
        {

        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Sacar(double quantia)
        {
            Saldo -= quantia;
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }
    }
}
