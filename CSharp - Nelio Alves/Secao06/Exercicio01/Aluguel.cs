namespace Exercicio01
{
    public class AluguelQuarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public AluguelQuarto(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
