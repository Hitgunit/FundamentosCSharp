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
using ConsoleApp1.Models;
using Fundamentos.Models;
using System.ComponentModel.Design;
using ConsoleApp1.Service;
using ConsoleApp1.Errors;

namespace ConsoleApp1
{
     class Program
    {
        public delegate void Mostrar(string cadena);
        static async Task Main(string[] args)
        {
            Mostrar mostrar = Show;
            HacerAlgo(mostrar);
        }

        public static void HacerAlgo(Mostrar funcionFinal)
        {
            Console.WriteLine("Hago algo");
            funcionFinal("Se envio desde otra funcion");
        }
        
        public static void Show(string cad)
        {
            Console.Write("Hola soy un delegado" + cad);
        }

        
    }
}
