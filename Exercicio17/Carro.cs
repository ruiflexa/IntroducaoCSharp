using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class Carro
    {
        private int placa;

        public virtual void showMsg()
        {
            Console.WriteLine("Véi, na boa...eu sou um carro");
        }

        public void setPlaca(int placa)
        {
            this.placa = placa;
        }

        public int getPlaca()
        {
            return placa;
        }

    }
}
