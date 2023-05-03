using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyFastFit.Models;

namespace MyFastFit.Data
{
    public class FastFitDbContext: IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public DbSet<Members> Members { get; set; }

        public FastFitDbContext(DbContextOptions<FastFitDbContext> options) : base(options)
        {
        }
    }
}
