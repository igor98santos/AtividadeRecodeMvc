using Microsoft.EntityFrameworkCore;
using Entrega.Models;

namespace Entrega.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 
        
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Voo> Voo { get; set; }
        public DbSet<Entrega.Models.Contato> Contato { get; set; }
    }
}
