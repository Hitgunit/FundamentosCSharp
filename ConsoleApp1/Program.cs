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
        //Se modifica a async task
        static async Task Main(string[] args)
        {
            //Se crea la lista de numeros
            List<int> numeros = new List<int>()
            {
                66, 1, 4, 5, 6, 7, 2, 3
            };
            var numerosOrdenados = numeros.OrderBy(x => x).ToList();
            foreach (var numero in numerosOrdenados)
            {
                Console.WriteLine(numero.ToString());
            }
        }
    }
}
