using APIDEPRACTICA.Models;
using Microsoft.EntityFrameworkCore;

namespace APIDEPRACTICA
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<Producto> Productos { get; set; }
    }
}
