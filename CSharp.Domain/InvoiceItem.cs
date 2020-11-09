using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Domain
{
    public class InvoiceItem
    {
        public string Description { get; set; }
        public decimal RatePerHour { get; set; } = 0m;
        public decimal HoursWorked { get; set; }
        public decimal TotalAmount => this.RatePerHour * this.HoursWorked;
        

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
