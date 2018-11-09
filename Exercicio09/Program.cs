using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 200;
            int n2 = 100;

            if (n1 > n2)
                Console.WriteLine("n1 maior");
            else
                Console.WriteLine("n2 maior");
            
            int num = 2;
            switch (num)
            {
                case 1:
                    Console.WriteLine("Number 1");
                    break;
                case 2:
                    Console.WriteLine("Number 2");
                    break;
                default:
                    Console.WriteLine("Valor nao encontrado");
                    break;
            }

            string nome = "Flexa";

            switch (nome)
            { 
                case "Gilmar":
                    Console.WriteLine("Gilmar Nunes");
                    break;
                case "Flexa":
                    Console.WriteLine("Rui Flexa");
                    break;

            }


            Console.ReadKey();
        }
    }
}
