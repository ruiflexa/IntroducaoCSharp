using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class Pessoa
    {
        //private string nome;
       // private int idade;

        public int Idade { get; set; }
        public string Nome { get; set; }

        //public string Nome { get => nome; set => nome = value; }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

       // public string getNome() { return nome; }
       // public int getIdade() { return idade; }


    }
}
