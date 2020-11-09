using FullStack.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullStack.Data
{
    public class FullStackDbContext: DbContext
    {
        public FullStackDbContext(DbContextOptions<FullStackDbContext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Forenames = "Admin",
                    Surname = "User",
                    Email ="admin@test.com",
                    Password = "administration",
                    Role = "Admin"
                },
                new User
                {
                    Id = 2,
                    Forenames = "Anthony",
                    Surname = "Coder",
                    Email = "anthonyCoder@gmail.com",
                    Password = "administration",
                    Role = "User"
                }
                );
        }
        }
}
