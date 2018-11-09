using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio18
{
    class Program
    {
        public struct Carro
        {
            public string nome;
            public int ano;
        }

        static void Main(string[] args)
        {
            Operacao somar = new Soma();
            Operacao subtrair = new Subtracao();

            Console.WriteLine(somar.calcular(2, 1));
            Console.WriteLine(subtrair.calcular(2, 0));

            Entidade pessoa = new Pessoa();
            pessoa.setNome("Aline");
            Console.WriteLine(pessoa.getNome());

            Carro c = new Carro();
            c.nome = "Ferrari";
            c.ano = 2018;

            List<int> lista = new List<int>();
            lista.Add(1); 
            lista.Add(2);
            

            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
