using Microsoft.EntityFrameworkCore;
using DiarioDaGratidaoV2.Shared.Entidades;

namespace DiarioDaGratidaoV2.Context
{
    public class NotaContext : DbContext
    {
        public NotaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Nota> Notas { get; set; }

        public DbSet<Cor> Cores { get; set; }
    }    
}
