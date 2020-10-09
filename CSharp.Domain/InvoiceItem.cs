using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Domain
{
    public class InvoiceItem
    {
        public string Description { get; set; }
        public double RatePerHour { get; set; }
        public double HoursWorked { get; set; }
        public double Amount { get; set; }

    }
}
