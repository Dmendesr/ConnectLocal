using Microsoft.EntityFrameworkCore;



namespace ConnectLocal.Models
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Contratante> Contratantes { get; set; } 
        public DbSet<Prestador> Prestadores { get; set; }
    }
}
