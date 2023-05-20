﻿using System;
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
            string url = "https://jsonplaceholder.typicode.com/posts";
            var client = new HttpClient();

            Post post = new Post()
            {
                userId = 1,
                body = "Hola soy un body",
                tittle = "Hola soy un titulo"
            };
            //Se convierte en un Json
            var data = JsonSerializer.Serialize<Post>(post);
            //Se manda el objeto tipo Json, su formato encoding (acentos y asi) y el tipo que se mandara (Json en este caso)
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            //Varaible para obtener la respuesta (post, update and delete)
            var httpResponse = await client.PostAsync(url, content);
            //Se valdia si fue exitoso
            if (httpResponse.IsSuccessStatusCode)
            {
                //Se pasa el valro a una variable
                var result = await httpResponse.Content.ReadAsStringAsync();
                //Se deserializa para hacer match con los atributos
                var postResult = JsonSerializer.Deserialize<Post>(result);
                //Se lee cada atributo
                Console.WriteLine(postResult.body);
            }
            
        }
    }
}
