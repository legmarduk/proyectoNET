using proyectoFinalNET.Models;
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

                Debug.Write("\n" + t.codigo_tipo_mascota + " " + t.nombre_tipo_mascota);
            }

            ListaTipos datosVista = new ListaTipos();
            datosVista.tipos = ltv;

            return View("Index", datosVista);
        }


        public ActionResult nuevaMascota(Mascota m)
        {
            Mascota test = new Mascota();
            test = m;
            Debug.Write("\n" + test.nombre_mascota);
            MascotaBusinessLayer mbl = new MascotaBusinessLayer();
            mbl.insertarMascota(m);

            return View();
        }


        public ActionResult getMascotasDueno(int rut)
        {
            List<Mascota> m = new List<Mascota>();
            MascotaBusinessLayer mbl = new MascotaBusinessLayer();

            m = mbl.getMascotasDueno(rut);
            List<MascotasView> lmv = new List<MascotasView>();

            foreach (Mascota mas in m)
            {
                MascotasView mv = new MascotasView();

                mv.codigo = mas.codigo_mascota;
                mv.nombre = mas.nombre_mascota;

                lmv.Add(mv);
            }
            ListaMascotaView datos = new ListaMascotaView();
            datos.mascotas = lmv;

            return View("axmascotas", datos);
        }

        public ActionResult ventanaHistorial()
        {
            return View("ventanaHistorial");
        }

        public ActionResult getHistorialMascota(int id)
        {
            List<HistorialMascota> historial = new List<HistorialMascota>();
            HistorialMascotaBusinessLayer h = new HistorialMascotaBusinessLayer();
            historial = h.getHistorialMascotas(id);

            List<HistorialViewModels> listaPaso = new List<HistorialViewModels>();

            foreach (HistorialMascota ht in historial)
            {
                HistorialViewModels hvm = new HistorialViewModels();
                hvm.fecha_visita = ht.fecha_visita;
                hvm.titulo_visita = ht.titulo_visita;
                hvm.tema_visita = ht.tema_visita;
                hvm.nombre_veterinaria = ht.veterinario_visita;

                listaPaso.Add(hvm);
            }

            ListaHistorial datos = new ListaHistorial();
            datos.datosHistorial = listaPaso;

            return View("axHistorial", datos);
        }

        public ActionResult VerMascotas()
        {
            return View();

        }

    }
}