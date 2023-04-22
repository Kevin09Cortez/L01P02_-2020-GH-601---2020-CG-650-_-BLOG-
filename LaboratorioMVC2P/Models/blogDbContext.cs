using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LaboratorioMVC2P.Models
{
    public class blogDbContext : DbContext
    {
        public blogDbContext(DbContextOptions<blogDbContext> options) : base(options) 
        {
        }

        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<publicaciones> publicaciones { get; set;}
        public DbSet<comentarios> comentarios { get; set; }
        public DbSet<calificaciones> calificaciones { get; set; }
    }
}
