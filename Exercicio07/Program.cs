using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gilmar Mendes";
            string sobrenome = nome.Substring(6, 7);

            string segundoNome = "Bruno";

            //Contains
            Console.WriteLine(nome.Contains("Gilmar"));

            //Length
            Console.WriteLine(nome.Length);

            //Substring
            Console.WriteLine(sobrenome);

            //Concat
            Console.WriteLine(string.Concat(segundoNome, "Marcel"));

            //Trim
            string nomeTrim = "Cesar           ";
            Console.WriteLine(nomeTrim.TrimEnd());

            //Split 
            string exSplit = "C# C++ Python";
            string[] vet = exSplit.Split(' ');
            for (int i = 0; i < vet.Length; i++)
                Console.WriteLine(vet[i]);

            //Join 
            string exSplitJoin = "C# C++ Python";
            string[] vetJoin = exSplitJoin.Split(' ');
            Console.WriteLine(String.Join(".", vetJoin));


            Console.ReadKey();
        }
    }
}
