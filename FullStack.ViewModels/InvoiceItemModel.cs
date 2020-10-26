using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.ViewModels
{
    public class InvoiceItemModel
    {
        public InvoiceItemModel()
        {
            RatePerHour = 0m;
        }
        public int InvoiceItemId { get; set; }
        public string Description { get; set; }
        public decimal RatePerHour { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal TotalAmount => this.RatePerHour * this.HoursWorked;
    }
}
