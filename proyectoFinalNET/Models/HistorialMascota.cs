using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoFinalNET.Models
{
    public class HistorialMascota
    {
        public int codigo_historial { get; set; }
        public DateTime fecha_visita { get; set; }
        public int codigo_mascota { get; set; }
        public string titulo_visita {get;set;}
        public string tema_visita { get; set; }
        public int codigo_veterinaria { get; set; }
        public string veterinario_visita { get; set; }
    }
}