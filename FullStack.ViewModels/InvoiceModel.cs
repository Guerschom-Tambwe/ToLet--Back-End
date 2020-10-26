using FullStack.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FullStack.ViewModels
{
    public class InvoiceModel
    {
        public InvoiceModel()
        {
            InvoiceItems = new List<InvoiceItem>();
        }

        public int InvoiceId { get; set; }
        public DateTimeOffset InvoiceDate { get; set; }
        public string InvoiceRefNumber { get; set; }
        public DateTimeOffset InvoiceDueDate { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }

        public decimal TotalInvoiceAmount => this.InvoiceItems.Sum(inv => inv.TotalAmount);
    }
}
