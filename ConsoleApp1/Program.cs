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
        static async Task Main(string[] args)
        {
            //Si todo sale bien se imprime todo lo que tiene el try
            try
            {

                var searcherBeer = new SeracherBeer();
                var cantidad = searcherBeer.GetCantidad("Pluto");
                Console.WriteLine("Excelente");

            }
            //Si no sale como se planea, un catch lo toma para que no se rompa el programa
            //Se puede tener varios catch de distintos parametros
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Exception 1");
            }
            //Este seria otro catch con otro parametro
            catch (FieldAccessException ex)
            {
                Console.WriteLine("Exception 2");
            }
            //El catch personalizado
            catch (BeerNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Este catch se utiliza para tener una excepcion no contemplada
            catch (Exception ex)
            {
                Console.WriteLine("Exception all");
            }
            //el finally siempre se ejecuta sin importra el resultado, sirve para cerrar por completo la operación
            finally 
            { 
                Console.WriteLine("Siempre se ejecuta");
            }
        }

        
    }
}
