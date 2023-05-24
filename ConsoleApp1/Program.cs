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

        public class Beer
        {
            public string Name { get; set; }
            public int Alcohol { get; set; }
        }
        static void Main(string[] args)
        {

            var beers = new List<Beer>(){
                new Beer() { Alcohol = 1, Name = "Jesus" },
                new Beer() { Alcohol = 1, Name = "Pablo" },
                new Beer() { Alcohol = 1, Name = "Chuy" },
                new Beer() { Alcohol = 1, Name = "Nino" }

        };

            ShowBeerThatMakesMeDrunk(beers, x => x.Alcohol >= 8);

        }

        static void ShowBeerThatMakesMeDrunk(List<Beer> beers, Predicate<Beer> condition)
        {
            var evilBeers = beers.FindAll(condition);
            evilBeers.ForEach(beer => Console.WriteLine(beer.Name));
        }



        
    }
}
