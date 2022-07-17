using Gestor_Proyectos.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gestor_Proyectos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Requerimiento> Requerimientos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Requerimiento>().HasIndex(x => x.Nombre_Iniciativa).IsUnique();
        }
    }
}
