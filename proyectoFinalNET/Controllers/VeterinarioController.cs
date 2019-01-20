using proyectoFinalNET.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoFinalNET.Controllers
{
    public class VeterinarioController : Controller
    {
        // GET: Veterinario
        public ActionResult Index()
        {
            return View("ventanaVeterinaria");
        }

        [HttpPost]
        public ActionResult guardarVeterinario(string nombre, string dir, string email, string pass) {
            Veterinaria vet = new Veterinaria();
            vet.nombre_veterinaria = nombre;
            vet.direccion_veterinaria = dir;
            vet.email = email;
            vet.password = pass;

            VeterinariaBusinessLayer vbl = new VeterinariaBusinessLayer();

            int respuesta;
            respuesta = vbl.insertarVet(vet);
            
            return View("ventanaVeterinaria");
        }
    }
}