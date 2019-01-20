using proyectoFinalNET.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace proyectoFinalNET.Models
{
    public class HistorialMascotaBusinessLayer
    {

        public List<HistorialMascota> getHistorialMascotas(int id)
        {
            Mascotas_DAL conex = new Mascotas_DAL();
            var idFinal = new SqlParameter("@id", id);

            try
            {
                return conex.Database.SqlQuery<HistorialMascota>("getHistorialMascota @id", idFinal).ToList();

            }
            catch (SqlException e)
            {
                Debug.Write(e);
                return null;
            }
       
        }

        public int SetHistorial(HistorialMascota hm)
        {
            Mascotas_DAL conex = new Mascotas_DAL();

            var idMascota = new SqlParameter("@id", hm.codigo_mascota);
            var titulo = new SqlParameter("@titulo", hm.titulo_visita);
            var detalle = new SqlParameter("@detalle", hm.tema_visita);
            var codigoVet = new SqlParameter("@codigoVet", hm.codigo_veterinaria);
            var nombreVet = new SqlParameter("@nombreVet",hm.veterinario_visita);

            try
            {
                conex.Database.ExecuteSqlCommand("SEThistorial @id, @titulo, @detalle, @codigoVet, @nombreVet", idMascota, titulo, detalle, codigoVet, nombreVet);

                return 1;

            } catch (Exception e)
            {
                Debug.Write(e.ToString());
                return 0;
            }

            
        }

    }
}