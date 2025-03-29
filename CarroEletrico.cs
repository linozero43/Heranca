using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class CarroEletrico:Carro
    {
        public int bateria;
        public int tempoDeCarga;

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine("Tempo de Carga " + tempoDeCarga);
            Console.WriteLine("Bateria " + bateria);
        }
    }
}
