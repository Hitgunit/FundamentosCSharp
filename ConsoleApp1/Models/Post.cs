using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Post : IRequestable
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string tittle { get; set; }
        public string body { get; set; }
    }
}
