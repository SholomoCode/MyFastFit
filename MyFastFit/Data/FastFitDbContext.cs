using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyFastFit.Models;
using Microsoft.Extensions.Logging;

namespace MyFastFit.Data
{
    public class FastFitDbContext: IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public DbSet<Members> Members { get; set; }

        public FastFitDbContext(DbContextOptions<FastFitDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
