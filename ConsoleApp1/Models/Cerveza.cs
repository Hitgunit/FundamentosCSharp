using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    class Cerveza : Bebida, IBebidaAlcoholica
    {

        public int Alcohol { get; set; }

        public string Marca { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo perimitido de una cerveza son 10");
        }

        public Cerveza(int Cantidad, string Nombre ) : base(Nombre, Cantidad)
        {
        }
    }
}
