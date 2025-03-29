using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Carro
    {
        public string modelo;
        public string marca;
        public int quilometragem;

        //Virtual - Esse metodo pode ser sobrescrito
        public virtual void MostrarInfo()
        {
            Console.WriteLine("Modelo "+modelo);
            Console.WriteLine("Marca "+marca);
            Console.WriteLine("Quilometagem "+quilometragem);
        }
        //Um metodo com mesmo nome poder receber cisas diferentes
        public void MostrarInfo(string nome)
        {
            Console.WriteLine("Modelo " + modelo);
            Console.WriteLine("Marca " + marca);
            Console.WriteLine("Quilometagem " + quilometragem);
            Console.WriteLine("Nome" + nome);

        }
    }
}
