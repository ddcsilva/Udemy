using Exercicio2.Entities;
using System;

namespace Exercicio2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Tenha uma boa viagem!");
            Comment c2 = new Comment("Wow que lindo!");
            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Viajando para Nova Zelândia", "Eu estou indo visitar um país maravilhoso!", 12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Boa noite!");
            Comment c4 = new Comment("Que a força esteja com você");
            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Boa noite pessoal", "Até amanhã", 5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
