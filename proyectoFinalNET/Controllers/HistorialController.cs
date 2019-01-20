using proyectoFinalNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoFinalNET.Controllers
{
    public class HistorialController : Controller
    {
        // GET: Historial
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult guardarHistorial(string codigo,string titulo, string detalle,string idvet)
        {
            HistorialMascota visita = new HistorialMascota();
            VeterinariaBusinessLayer vbl = new VeterinariaBusinessLayer();

            visita.codigo_mascota = Convert.ToInt32(codigo);
            visita.titulo_visita = titulo;
            visita.tema_visita = detalle;
            visita.codigo_veterinaria = 1;// Convert.ToInt32(idvet);
            visita.veterinario_visita = vbl.getVeterinarianame(visita.codigo_veterinaria);

            HistorialMascotaBusinessLayer hbl = new HistorialMascotaBusinessLayer();

            hbl.SetHistorial(visita);


            return View();
        }
    }
}