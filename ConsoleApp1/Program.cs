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
            List<Cerveza> list = new List<Cerveza>()
            {
                new Cerveza() { Alcohol = 1, }
            };
        }
    }
}
