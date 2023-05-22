using ConsoleApp1.Models;
using Fundamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    //La "T" indica que va a recibir una clase con la cual va a trabajar
    //El Where implementa un condicion, solo recibira a quien cumpla con la interfaz IRequetable
    //Se pueden usar mas de una clase e igual se puede delimitar 
    public class SendRequest<T, U> where T : IRequestable where U : IBebidaAlcoholica
    {
        private HttpClient _client = new HttpClient();
        //Se crea una clase que funcionara con cualquier clase que reciba
        public async Task<T> Send (T model )
        {
            string url = "https://jsonplaceholder.typicode.com/posts";

            //Se convierte en un Json
            var data = JsonSerializer.Serialize<T>(model);
            //Se manda el objeto tipo Json, su formato encoding (acentos y asi) y el tipo que se mandara (Json en este caso)
            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            //Varaible para obtener la respuesta (post, update and delete)
            var httpResponse = await _client.PostAsync(url, content);
            //Se valdia si fue exitoso
            if (httpResponse.IsSuccessStatusCode)
            {
                //Se pasa el valro a una variable
                var result = await httpResponse.Content.ReadAsStringAsync();
                //Se deserializa para hacer match con los atributos
                var postResult = JsonSerializer.Deserialize<T>(result);
                //si es exitoso regresa el postResult
                return postResult;
            }
            //En caso de que falle se manda llamar a default ya que no se puede regresar un null
            return default(T);
        }
    }
}
