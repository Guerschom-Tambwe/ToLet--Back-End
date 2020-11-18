using System.ComponentModel.DataAnnotations.Schema;

namespace FullStack.Data.Entities
{
    public class InvoiceItem
    {
        public int InvoiceItemId { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal RatePerHour { get; set; } = 0m;
        [Column(TypeName = "decimal(5,2)")]
        public decimal HoursWorked { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal TotalAmount => RatePerHour * HoursWorked;
        public int InvoiceId { get; set; }


        public static InvoiceItem Create(string description, decimal ratePerHour, decimal hoursWorked)
        {
            return new InvoiceItem
            {
                Description = description,
                HoursWorked = hoursWorked,
                RatePerHour = ratePerHour,
            };
        }
    }
}
