using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FullStack.Data.Entities
{
    public class Invoice
    {
        public Invoice()
        {
            InvoiceItems = new List<InvoiceItem>();
        }

        public int InvoiceId { get; set; }
        public DateTimeOffset InvoiceDate { get; set; }
        public string InvoiceRefNumber { get; set; }
        public DateTimeOffset InvoiceDueDate { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; }
        public decimal TotalInvoiceAmount => this.InvoiceItems.Sum(inv => inv.TotalAmount);

        public DateTimeOffset CalculateInvoiceDate(int nthMonth)
        {
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);
            var invoiceDate = currentDate.AddMonths(nthMonth).AddDays(-6);
            return invoiceDate;
        }

        public DateTimeOffset CalculateInvoiceDueDate(int nthMonth)
        {
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);
            InvoiceDueDate = currentDate.AddMonths(nthMonth).AddDays(-1);
            return InvoiceDueDate;
        }


    }
}
