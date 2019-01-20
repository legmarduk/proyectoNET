using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectoFinalNET.ViewModels
{
    public class ListaMascotaView
    {
        public string carga {get;set;}
        public List<MascotasView> mascotas { get; set; }
        public string rut { get; set; }
        public string nombre_dueno { get; set; }
    }
}