using Microsoft.EntityFrameworkCore;
using GestInvest.Models;

namespace GestInvest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Acao> Acoes { get; set; }
    }
}
