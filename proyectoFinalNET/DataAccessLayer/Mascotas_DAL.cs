using System.Data.Entity;

namespace proyectoFinalNET.DataAccessLayer
{
    public class Mascotas_DAL : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}