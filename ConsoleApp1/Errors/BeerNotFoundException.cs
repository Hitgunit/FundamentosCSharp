using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Errors
{
    //Se hereda de exception
    public class BeerNotFoundException : Exception
    {
        //Se crea un constructor que a la vez invoca a su padre
        public BeerNotFoundException() : base() { }
        //Se puede agregar mas de un constructor
        //Se crea el constructor para que mand eun mensaje y al padre tambien
        public BeerNotFoundException(string message) : base(message) { }
        //Una excepcion puede tener mas de una excepcion
        public BeerNotFoundException(string message, Exception inner) : base(message, inner) { }

    }
}
