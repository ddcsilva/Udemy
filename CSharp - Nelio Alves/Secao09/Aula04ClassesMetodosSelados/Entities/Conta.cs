namespace Aula04ClassesMetodosSelados.Entities
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

        public virtual void Sacar(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }
    }
}
