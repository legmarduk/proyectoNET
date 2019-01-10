using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoFinalNET.Models
{
    public class Mascota
    {
        public int codigo_mascota { get; set; }
        public string nombre_mascota { get; set; }
        public int codigo_tipo_mascota { get; set; }
        public DateTime fecha_incripcion { get; set; }
        public int numero_chip { get; set; }
        public string nombre_dueno { get; set; }
        public string rut_dueno { get; set; }
    }
}