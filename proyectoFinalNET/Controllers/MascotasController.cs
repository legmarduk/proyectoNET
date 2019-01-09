﻿using proyectoFinalNET.Models;
using proyectoFinalNET.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proyectoFinalNET.Controllers
{
    public class MascotasController : Controller
    {
        // GET: Mascota
        public ActionResult Index()
        {

            List<TipoMascota> tipos = new List<TipoMascota>();
            TipoMascotaBusinessLayer tbl = new TipoMascotaBusinessLayer();

            tipos = tbl.getTipoMascotas(); 

            List<TiposVista> ltv = new List<TiposVista>();

            foreach (TipoMascota t in tipos)
            {
                /*creo el objeto tipo vista*/
                TiposVista tv = new TiposVista();

                tv.codigo = t.codigo_tipo_mascota;
                tv.tipo_mascota = t.nombre_tipo_mascota;

                ltv.Add(tv); //agrego tv a lista TiposVista

                Debug.Write("\n"+t.codigo_tipo_mascota + " " + t.nombre_tipo_mascota);
            }

            ListaTipos datosVista = new ListaTipos();
            datosVista.tipos = ltv;
            
            return View("Index", datosVista);
        }


        public ActionResult nuevaMascota(Mascota m)
        {
            
            Mascota test = new Mascota();
            test = m;
            Debug.Write("\n"+ test.nombre_mascota);
            MascotaBusinessLayer mbl = new MascotaBusinessLayer();
            mbl.insertarMascota(m);

                return View();
         
            
        }

    }
}