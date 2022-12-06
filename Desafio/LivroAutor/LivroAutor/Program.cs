using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroAutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro novoLivro = new Livro();
            novoLivro.Autors.Add(new Autor("Gustavo", "gustavo@mail.com"));

            foreach (var elemento in novoLivro.Autors)
            {
                Console.WriteLine("Nome: " + elemento.Nome);
                Console.WriteLine("Email: " + elemento.Email);
            }
        }
    }
}
