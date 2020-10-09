using System;
using CSharp.Domain;

namespace CSharp.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoiceStore = new InvoiceStore();
            var createdInvoices = invoiceStore.CreateInvoices();
       }
    }
}
