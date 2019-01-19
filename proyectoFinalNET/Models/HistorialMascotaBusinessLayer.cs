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

    }
}