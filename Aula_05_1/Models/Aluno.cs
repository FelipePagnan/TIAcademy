using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_04.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
        

        public override void ApresentarAluno(){
            System.Console.WriteLine($"Olá, meu nome é {Nome}, eu tenho {Idade} anos e sou um aluno nota {Nota}");
        }
    }
}