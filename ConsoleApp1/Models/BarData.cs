﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fundamentos.Models;

namespace ConsoleApp1.Models
{
    public class BarData
    {
        public string Nombre { get; set; }
        public List<Bebida> bebidas = new List<Bebida>();

        public BarData(string Nombre)
        {
            this.Nombre = Nombre;
        }

    }
}
