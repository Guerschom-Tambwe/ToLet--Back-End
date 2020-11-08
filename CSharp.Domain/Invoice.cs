using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace CSharp.Domain
{
    public class Invoice
    {

        public Invoice()
        {
            InvoiceItems = new List<InvoiceItem>();
        }
        public DateTimeOffset InvoiceDate { get; set; } 
        public string InvoiceRefNumber { get; set; }
        public DateTimeOffset InvoiceDueDate { get; set; }
        public List<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

        public decimal TotalInvoiceAmount => this.InvoiceItems.Sum(inv => inv.TotalAmount);

        public DateTimeOffset CalculateInvoiceDate(int nthMonth, DateTimeOffset currentDate)
        {
            InvoiceDate = currentDate.AddMonths(nthMonth).AddDays(-6);
            return InvoiceDate;
        }

        public DateTimeOffset CalculateInvoiceDueDate(int nthMonth, DateTimeOffset currentDate)
        {
            InvoiceDueDate = currentDate.AddMonths(nthMonth).AddDays(-1);
            return InvoiceDueDate;
        }


    }
}
