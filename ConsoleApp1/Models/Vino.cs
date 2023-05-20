using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
        class Vino : Bebida, IBebidaAlcoholica
        {

            public int Alcohol { get; set; }
            public string Marca { get; set; }

             public void MaxRecomendado()
            {
                Console.WriteLine("El maximo perimitido de una cerveza son 3 copas");
            }

            public Vino (int Cantidad, string Nombre = "Vino") : base(Nombre, Cantidad)
            {
            }
        }
    
}
