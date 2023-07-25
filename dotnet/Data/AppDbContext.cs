using dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Data
{   
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
