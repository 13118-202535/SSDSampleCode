using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using L03ProactiveControls.Models;

namespace L03ProactiveControls.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<L03ProactiveControls.Models.Customer> Customer { get; set; } = default!;
    }
}
