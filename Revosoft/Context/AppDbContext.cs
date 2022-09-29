using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Revosoft.Models;

namespace Revosoft.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Veiculos> Veiculos { get; set; }
        public DbSet<Enderecos> Enderecos { get; set; }
        public DbSet<Pecas> Pecas { get; set; }
    }
}
