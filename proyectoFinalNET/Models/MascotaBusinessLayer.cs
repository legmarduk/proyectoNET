using proyectoFinalNET.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace proyectoFinalNET.Models
{
    public class MascotaBusinessLayer
    {
        public int insertarMascota(Mascota m)
        {
            Mascotas_DAL conex = new Mascotas_DAL();

            var nombre = new SqlParameter("@nombre_mascota",m.nombre_mascota);
            var codigo_tipo = new SqlParameter("@codigo_tipo_mascota",m.codigo_tipo_mascota);
            var numero_chip = new SqlParameter("@numero_chip", m.numero_chip);
            var nombre_dueno = new SqlParameter("@nombre_dueno",m.nombre_dueno);
            var rut_dueno = new SqlParameter("@rut_dueno", m.rut_dueno);

            try
            {
                conex.Database.ExecuteSqlCommand("SETnewMascota @nombre_mascota, @codigo_tipo_mascota, @numero_chip, @nombre_dueno, @rut_dueno",
                    nombre,codigo_tipo,numero_chip,nombre_dueno,rut_dueno);


                return 1;
            }
            catch (Exception e)
            {
                Debug.Write(e.ToString());
                return 0;
            }
          
        }
    }
}