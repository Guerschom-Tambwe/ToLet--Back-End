using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Domain
{
    public class Invoice
    {
        public string InvoiceDate { get; set; } //Date will be stored as a string
        public string InvoiceRefNumber { get; set; }
        public string InvoiceDueDate { get; set; } //Date will be stored as a string
        public List<InvoiceItem> InvoiceItems { get; set; }
        public string TotalInvoiceAmount { get; set; } //TotalInvoiceAmount will be stored as a currency




    }
}
