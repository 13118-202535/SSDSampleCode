using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using L02CommonAttacks.Models;

namespace L02CommonAttacks.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<L02CommonAttacks.Models.Car> Car { get; set; } = default!;
    }
}
