using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class Program
    {

        static void MostrarDados(string nome)
        {
            Console.WriteLine(nome);
        }

        static void MostrarDados(string nome, int idade)
        {
            Console.WriteLine("Nome: {0} | Idade: {1}", nome, idade);
        }

        static void SetNome(string nome = "Sem nome")
        {
            Console.WriteLine(nome);
        }


        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Samuel", 30);
            Console.WriteLine(pessoa.Nome);

            MostrarDados("Bruno", 30);
            SetNome();

            Carro carro = new Ferrari(4321);
            Console.WriteLine(carro.getPlaca());

            carro.showMsg();

 

            Console.ReadKey();

        }
    }
}
