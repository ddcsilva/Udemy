namespace Aula04ClassesMetodosSelados.Entities
{
    public class ContaComercial : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaComercial()
        {

        }

        public ContaComercial(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestar(double quantia)
        {
            if (quantia <= LimiteEmprestimo)
            {
                Saldo += quantia;
            }
        }
    }
}
