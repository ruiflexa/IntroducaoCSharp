using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17
{
    class Ferrari : Carro
    {
        public Ferrari(int placa)
        {
            setPlaca(placa);
        }

        public override void showMsg()
        {
            Console.WriteLine("AQUI É FERRARI, P#@$.");
        }

        //public override void showMsg()
        //{
        //    base.showMsg();
        //}
    }
}
