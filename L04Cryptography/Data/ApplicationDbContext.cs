using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using L04Cryptography.Models;

namespace L04Cryptography.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<L04Cryptography.Models.Password> Password { get; set; } = default!;
        public DbSet<L04Cryptography.Models.BankAccount> BankAccount { get; set; } = default!;
    }
}
