using proyectoFinalNET.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace proyectoFinalNET.Models
{
    public class VeterinariaBusinessLayer
    {
        public int insertarVet(Veterinaria v)
        {
            Mascotas_DAL conex = new Mascotas_DAL();

            var nombre_veterinaria = new SqlParameter("@nombre", v.nombre_veterinaria);
            var password = new SqlParameter("@password", v.password);
            var direccion_veterinaria = new SqlParameter("@direccion", v.direccion_veterinaria);
            var email = new SqlParameter("@email", v.email);

            try {
                conex.Database.ExecuteSqlCommand("SETnewVeterinario @nombre, @password, @direccion, @email", 
                    nombre_veterinaria, password, direccion_veterinaria, email);
                return 1;
            }
            catch (SqlException e) {
                Debug.Write(e.ToString());
                return 0;
            }
        }

        public int editarVet(Veterinaria v)
        {
            Mascotas_DAL conex = new Mascotas_DAL();

            var nombre_veterinaria = new SqlParameter("@nombre", v.nombre_veterinaria);
            var password = new SqlParameter("@password", v.password);
            var direccion_veterinaria = new SqlParameter("@direccion", v.direccion_veterinaria);
            var email = new SqlParameter("@email", v.email);

            try
            {
                conex.Database.ExecuteSqlCommand("editVeterinario @nombre, @password, @direccion, @email",
                    nombre_veterinaria, password, direccion_veterinaria, email);
                return 1;
            }
            catch (SqlException e)
            {
                Debug.Write(e.ToString());
                return 0;
            }
        }

        public void deleteVet(int id) {
            Mascotas_DAL conex = new Mascotas_DAL();
            var ide = new SqlParameter("@id", id);

            conex.Database.ExecuteSqlCommand("deleteVet @id", ide);
        }

        public string getVeterinarianame(int id) {
            Mascotas_DAL conex = new Mascotas_DAL();
            var ide = new SqlParameter("@id", id);

            return conex.Database.ExecuteSqlCommand("getNombreVet @id", ide).ToString();
        }
    }
}