using ConsoleApp1.Errors;
using Fundamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    public class SeracherBeer
    {
        List<Cerveza> cervezas = new List<Cerveza>()
        {
            new Cerveza (50, "Jose")  { Alcohol=10, Marca = "JoseCuervo"},
            new Cerveza (50, "Pepe")  { Alcohol=5, Marca = "Raulensio"},
            new Cerveza (50, "Jhonson")  { Alcohol=2, Marca = "Bostamante"}
        };

        public int GetCantidad (string Nombre)
        {
            var cerveza = (from d in cervezas
                          where d.Nombre == Nombre
                          select d).FirstOrDefault();
            if (cerveza == null)
                throw new BeerNotFoundException("La cerveza se ha terminado");

            return cerveza.Cantidad;
        }

    }
}
