using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Cerveza : Bebida, IBebidaAlcoholica, IRequestable
    {

        public int Alcohol { get; set; }

        public string Marca { get; set; }

        public int Id { get; set; }

        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo perimitido de una cerveza son 10");
        }

        public Cerveza(int Cantidad, string Nombre ) : base(Nombre, Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }
    }
}
