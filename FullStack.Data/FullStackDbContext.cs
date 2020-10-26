using FullStack.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullStack.Data
{
    public class FullStackDbContext: DbContext
    {
        /*public FullStackDbContext(DbContextOptions<FullStackDbContext> options)
           : base(options)
        {
        }*/

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=LAPTOP-R8498E5C;Initial Catalog=InvoiceAppData;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entityOfMethodsUsed = new Invoice();

            modelBuilder.Entity<Invoice>().HasData(
                new Invoice
                {
                    InvoiceId = 1,
                    InvoiceDate = entityOfMethodsUsed.CalculateInvoiceDate(1),
                    InvoiceRefNumber = "invoice001",
                    InvoiceDueDate = entityOfMethodsUsed.CalculateInvoiceDueDate(2),
                },
                new Invoice
                {
                    InvoiceId = 2,
                    InvoiceDate = entityOfMethodsUsed.CalculateInvoiceDate(2),
                    InvoiceDueDate = entityOfMethodsUsed.CalculateInvoiceDueDate(3),
                    InvoiceRefNumber = "invoice002",
                },
                new Invoice
                {
                    InvoiceId = 3,
                    InvoiceDate = entityOfMethodsUsed.CalculateInvoiceDate(3),
                    InvoiceDueDate = entityOfMethodsUsed.CalculateInvoiceDueDate(4),
                    InvoiceRefNumber = "invoice003",
                },
                new Invoice
                {
                    InvoiceId = 4,
                    InvoiceDate = entityOfMethodsUsed.CalculateInvoiceDate(4),
                    InvoiceDueDate = entityOfMethodsUsed.CalculateInvoiceDueDate(5),
                    InvoiceRefNumber = "invoice004",
                },
                new Invoice
                {
                    InvoiceId = 5,
                    InvoiceDate = entityOfMethodsUsed.CalculateInvoiceDate(5),
                    InvoiceDueDate = entityOfMethodsUsed.CalculateInvoiceDueDate(6),
                    InvoiceRefNumber = "invoice005",
                },
                new Invoice
                {
                    InvoiceId = 6,
                    InvoiceDate = entityOfMethodsUsed.CalculateInvoiceDate(6),
                    InvoiceDueDate = entityOfMethodsUsed.CalculateInvoiceDueDate(7),
                    InvoiceRefNumber = "invoice006"
                },
                new Invoice
                {
                    InvoiceId = 7,
                    InvoiceDate = entityOfMethodsUsed.CalculateInvoiceDate(7),
                    InvoiceDueDate = entityOfMethodsUsed.CalculateInvoiceDueDate(8),
                    InvoiceRefNumber = "invoice007",
                },
                new Invoice
                {
                    InvoiceId = 8,
                    InvoiceDate = entityOfMethodsUsed.CalculateInvoiceDate(8),
                    InvoiceDueDate = entityOfMethodsUsed.CalculateInvoiceDueDate(9),
                    InvoiceRefNumber = "invoice008",
                },
                new Invoice
                {
                    InvoiceId = 9,
                    InvoiceDate = entityOfMethodsUsed.CalculateInvoiceDate(9),
                    InvoiceDueDate = entityOfMethodsUsed.CalculateInvoiceDueDate(10),
                    InvoiceRefNumber = "invoice009",
                },
                new Invoice
                {
                    InvoiceId = 10,
                    InvoiceDate = entityOfMethodsUsed.CalculateInvoiceDate(10),
                    InvoiceDueDate = entityOfMethodsUsed.CalculateInvoiceDueDate(11),
                    InvoiceRefNumber = "invoice010",
                },
                new Invoice
                {
                    InvoiceId = 11,
                    InvoiceDate = entityOfMethodsUsed.CalculateInvoiceDate(11),
                    InvoiceDueDate = entityOfMethodsUsed.CalculateInvoiceDueDate(12),
                    InvoiceRefNumber = "invoice011",
                },
                new Invoice
                {
                    InvoiceId = 12,
                    InvoiceDate = entityOfMethodsUsed.CalculateInvoiceDate(12),
                    InvoiceDueDate = entityOfMethodsUsed.CalculateInvoiceDueDate(13),
                    InvoiceRefNumber = "invoice012",
                }

                );

            modelBuilder.Entity<InvoiceItem>().HasData(
                new InvoiceItem
                {
                    InvoiceItemId = 1,
                    Description = "Desktop Technology Support",
                    HoursWorked = 400,
                    RatePerHour = 84,
                    InvoiceId = 1
                },
                new InvoiceItem
                {
                    InvoiceItemId = 2,
                    Description = "Network/Server Technolody Support",
                    HoursWorked = 365,
                    RatePerHour = 91,
                    InvoiceId = 1
                },
                new InvoiceItem
                {
                    InvoiceItemId = 3,
                    Description = "Security patches & CMS updates",
                    HoursWorked = 200,
                    RatePerHour = 400,
                    InvoiceId = 1
                },
                new InvoiceItem
                {
                    InvoiceItemId = 4,
                    Description = "Desktop Technology Support",
                    HoursWorked = 300,
                    RatePerHour = 84,
                    InvoiceId = 2
                },
                new InvoiceItem
                {
                    InvoiceItemId = 5,
                    Description = "Desktop Technology Support",
                    HoursWorked = 200,
                    RatePerHour = 400,
                    InvoiceId = 2
                },
                new InvoiceItem
                {
                    InvoiceItemId = 6,
                    Description = "Advanced Technology Support",
                    HoursWorked = 487,
                    RatePerHour = 84,
                    InvoiceId = 3                   
                },
                new InvoiceItem
                {
                    InvoiceItemId = 7,
                    Description = "Security patches & CMS updates",
                    HoursWorked = 265,
                    RatePerHour = 578,
                    InvoiceId = 3
                },
                new InvoiceItem
                {
                    InvoiceItemId = 8,
                    Description = "After-hours maintenance",
                    HoursWorked = 1000,
                    RatePerHour = 1200,
                    InvoiceId = 3
                },
                new InvoiceItem
                {
                    InvoiceItemId = 9,
                    Description = "Full web maintenance",
                    HoursWorked = 300,
                    RatePerHour = 84,
                    InvoiceId = 4
                },
                new InvoiceItem
                {
                    InvoiceItemId = 10,
                    Description = "Security patches & CMS updates",
                    HoursWorked = 300,
                    RatePerHour = 84,
                    InvoiceId = 4
                },
                new InvoiceItem
                {
                    InvoiceItemId = 11,
                    Description = "Network/Server Technology",
                    HoursWorked = 300,
                    RatePerHour = 579,
                    InvoiceId = 4
                },
                new InvoiceItem
                {
                    InvoiceItemId = 12,
                    Description = "Premier Consulting Services",
                    HoursWorked = 300,
                    RatePerHour = 84,
                    InvoiceId = 5
                },
                new InvoiceItem
                {
                    InvoiceItemId = 13,
                    Description = "Desktop Technology Support",
                    HoursWorked = 300,
                    RatePerHour = 695,
                    InvoiceId = 6
                },
                new InvoiceItem
                {
                    InvoiceItemId = 14,
                    Description = "Desktop Technology Support",
                    HoursWorked = 987,
                    RatePerHour = 789,
                    InvoiceId = 6
                },
                new InvoiceItem
                {
                    InvoiceItemId = 15,
                    Description = "After-hour maintenance",
                    HoursWorked = 250,
                    RatePerHour = 89,
                    InvoiceId = 7
                },
                new InvoiceItem
                {
                    InvoiceItemId = 16,
                    Description = "Security patches & CMS updates",
                    HoursWorked = 200,
                    RatePerHour = 400,
                    InvoiceId = 7
                },
                new InvoiceItem
                {
                    InvoiceItemId = 17,
                    Description = "Security patches & CMS updates",
                    HoursWorked = 200,
                    RatePerHour = 400,
                    InvoiceId = 7

                },
                new InvoiceItem
                {
                    InvoiceItemId = 18,
                    Description = "Desktop Technology Support",
                    HoursWorked = 300,
                    RatePerHour = 84,
                    InvoiceId = 8
                },
                new InvoiceItem
                {
                    InvoiceItemId = 19,
                    Description = "Desktop Technology Support",
                    HoursWorked = 200,
                    RatePerHour = 400,
                    InvoiceId = 8
                },
                new InvoiceItem
                {
                    InvoiceItemId = 20,
                    Description = "Desktop Technology Support",
                    HoursWorked = 479,
                    RatePerHour = 9876,
                    InvoiceId = 8
                },
                new InvoiceItem
                {
                    InvoiceItemId = 21,
                    Description = "Desktop Technology Support",
                    HoursWorked = 479,
                    RatePerHour = 9876,
                    InvoiceId = 8
                },
                new InvoiceItem
                {
                    InvoiceItemId = 22,
                    Description = "Full web maintenance",
                    HoursWorked = 960,
                    RatePerHour = 400,
                    InvoiceId = 9
                },
                new InvoiceItem
                {
                    InvoiceItemId = 23,
                    Description = "Full web maintenance",
                    HoursWorked = 450,
                    RatePerHour = 789,
                    InvoiceId = 9
                },
                new InvoiceItem
                {
                    InvoiceItemId = 24,
                    Description = "Desktop Technology Support",
                    HoursWorked = 300,
                    RatePerHour = 84,
                    InvoiceId = 10
                },
                new InvoiceItem
                {
                    InvoiceItemId = 25,
                    Description = "Desktop Technology Support",
                    HoursWorked = 200,
                    RatePerHour = 84,
                    InvoiceId = 10
                },
                new InvoiceItem
                {
                    InvoiceItemId = 26,
                    Description = "Desktop Technology Support",
                    HoursWorked = 300,
                    RatePerHour = 84,
                    InvoiceId = 11
                },
                new InvoiceItem
                {
                    InvoiceItemId = 27,
                    Description = "Desktop Technology Support",
                    HoursWorked = 200,
                    RatePerHour = 400,
                    InvoiceId = 11
                },
                new InvoiceItem
                {
                    InvoiceItemId = 28,
                    Description = "Desktop Technology Support",
                    HoursWorked = 300,
                    RatePerHour = 84,
                    InvoiceId = 12
                },
                new InvoiceItem
                {

                    InvoiceItemId = 29,
                    Description = "Desktop Technology Support",
                    HoursWorked = 200,
                    RatePerHour = 400,
                    InvoiceId = 12
                }

                );
        }
        }
}
