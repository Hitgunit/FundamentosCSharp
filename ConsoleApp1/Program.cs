using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Fundamentos.Models;
using System.IO;
using System.Net.Http;

namespace ConsoleApp1
{
     class Program
    {
        static async Task Main(string[] args)
        {
            List<Cerveza> cervezas = new List<Cerveza>()
            {
                new Cerveza(1, "Jorge") { Alcohol = 1, Marca="Pepsi" },
                new Cerveza(2, "Goku") { Alcohol = 5, Marca="Seven" },
                new Cerveza(3, "Pepe") { Alcohol = 4, Marca="Jorgel" },
                new Cerveza(4, "Alli") { Alcohol = 3, Marca="Corona" }
            };

            var cervezasOrdenadas = from d in cervezas
                                    where d.Nombre == "Jorge" && d.Marca == "Pepsi"
                                    select d;

            foreach(var cerveza in cervezasOrdenadas)
            {
                Console.WriteLine($"{cerveza.Nombre}, {cerveza.Marca}");
            }
        }
    }
}
