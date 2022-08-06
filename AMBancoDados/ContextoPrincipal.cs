using AM.Domain;

using Microsoft.EntityFrameworkCore;

using System;

namespace AMBancoDados
{
    public class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Carros> Carros { get; set; }
    }
}
