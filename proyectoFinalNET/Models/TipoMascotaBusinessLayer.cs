using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using proyectoFinalNET.DataAccessLayer;
using System.Data.SqlClient;

namespace proyectoFinalNET.Models
{
    public class TipoMascotaBusinessLayer
    {
  
        public List<TipoMascota> getTipoMascotas()
        {
            try
            {
                Mascotas_DAL conex = new Mascotas_DAL();

                return conex.Database.SqlQuery<TipoMascota>("getTipoMascota").ToList();

            } catch (SqlException e)
            {
                Debug.Write(e);

                return null;
            }
        }

    }
}