using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo do-while
            int soma = 0;
            int i = 1;
            do
            {
                soma += 1;
                i++;
            } while (i <= 10);

            Console.WriteLine(soma);

            //Exemplo for
            soma = 0; //reinicializando a variável soma para exemplo for
            for (int j = 1; j <= 10; j++)
                soma += j;

            Console.WriteLine(soma);

            //Exemplo while
            soma = 0; //reinicializando a variável soma para exemplo while
            int k = 1; 
            while (k <= 10)
            {
                soma += k;
                k++;
            }

            Console.WriteLine(soma);
            Console.ReadKey();

        }
    }
}
