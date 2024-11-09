using Microsoft.EntityFrameworkCore;
using T1_Perez_Mayk.Models;

namespace T1_Perez_Mayk.Datos
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    public DbSet<Distribuidor> Distribuidor { get; set; }
    }
}
