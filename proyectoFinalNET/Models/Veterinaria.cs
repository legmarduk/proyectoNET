using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoFinalNET.Models
{
    public class Veterinaria
    {
        public int codigo_veterinaria { get; set; }
        public string nombre_veterinaria { get; set; }
        public string password { get; set; }
        public string direccion_veterinaria {get;set;}
        public string email { get; set; }
    }
}