using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    public class LinguagemException: Exception
    {
        public LinguagemException(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
