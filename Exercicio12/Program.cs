﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 0;
                int div = 10 / n;
                Console.WriteLine(div);
                string linguagem = "Java Love!";

                if (linguagem == "Java Love!")
                    throw new LinguagemException("Texto Exceção");

            }
            catch (LinguagemException)
            {
                Console.Write("Exceção capturada: Divisao por zero");
            }
            finally
            {
                Console.WriteLine("Valeus! Flws!");
            }
            Console.ReadKey();
        }
    }
}
