using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.Data.Entities
{
    public class InvoiceItem
    {
        public int InvoiceItemId { get; set; }
        public string Description { get; set; }
        public decimal RatePerHour { get; set; } = 0m;
        public decimal HoursWorked { get; set; }
        public decimal TotalAmount => this.RatePerHour * this.HoursWorked;
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

        public static InvoiceItem Create(int id, string description, decimal ratePerHour, decimal hoursWorked, int invoiceId)
        {
            return new InvoiceItem
            {
                InvoiceItemId = id,
                Description = description,
                HoursWorked = hoursWorked,
                RatePerHour = ratePerHour,
                InvoiceId = invoiceId
            };
        }
    }
}
