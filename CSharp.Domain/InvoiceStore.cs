using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Domain
{
    public class InvoiceStore
    {
        public List<Invoice> CreateInvoices()
        {
            var invoice = new Invoice();
            var invoiceItem = new InvoiceItem();

            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoices = new List<Invoice>();


            //Invoice 1
            invoices.Add(new Invoice()
            {
                InvoiceDate = invoice.CalculateInvoiceDate(1, currentDate),
                InvoiceRefNumber = "invoice001",
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(2, currentDate),
                InvoiceItems = new List<InvoiceItem>()
                {
                    InvoiceItem.Create("Desktop Technology Support", 400, 84),
                    InvoiceItem.Create("Network/Server Technolody Support", 365, 91),
                    InvoiceItem.Create("Security patches & CMS updates", 200, 400)
                },
            }
                ); ;
           

            //Invoice 2
            invoices.Add(new Invoice()
            {
                InvoiceDate = invoice.CalculateInvoiceDate(2, currentDate),
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(3, currentDate),
                InvoiceRefNumber = "invoice002",
                InvoiceItems = new List<InvoiceItem>()
                {
                     InvoiceItem.Create("Desktop Technology Support", 300, 84),
                     InvoiceItem.Create("Desktop Technology Support", 200, 400)
                },
            }
            );

            //Invoice 3
            invoices.Add(new Invoice()
            {
                InvoiceDate = invoice.CalculateInvoiceDate(3, currentDate),
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(4, currentDate),
                InvoiceRefNumber = "invoice003",
                InvoiceItems = new List<InvoiceItem>()
                {
                    InvoiceItem.Create("Advanced Technology Support", 487, 84),
                    InvoiceItem.Create("Security patches & CMS updates", 265, 578),
                    InvoiceItem.Create("After-hours maintenance", 1000, 1200)
                },

            }
            );

            //Invoice 4
            invoices.Add(new Invoice()
            {
                InvoiceDate = invoice.CalculateInvoiceDate(4, currentDate),
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(5, currentDate),
                InvoiceRefNumber = "invoice004",
                InvoiceItems = new List<InvoiceItem>()
                {
                    InvoiceItem.Create("Full web maintenance", 300, 84),
                    InvoiceItem.Create("Security patches & CMS updates", 300, 84),
                    InvoiceItem.Create("Network/Server Technology", 300, 579)
                },
            }
            );


            //Invoice 5
            invoices.Add(new Invoice()
            {
                InvoiceDate = invoice.CalculateInvoiceDate(5, currentDate),
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(6, currentDate),
                InvoiceRefNumber = "invoice005",
                InvoiceItems = new List<InvoiceItem>()
                {
                    InvoiceItem.Create("Premier Consulting Services", 300, 84),
                    InvoiceItem.Create("Desktop Technology Support", 200, 400)
                },
            }
            );


            //Invoice 6
            invoices.Add(new Invoice()
            {
                InvoiceDate = invoice.CalculateInvoiceDate(6, currentDate),
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(7, currentDate),
                InvoiceRefNumber = "invoice006",
                InvoiceItems = new List<InvoiceItem>()
                {
                    InvoiceItem.Create("Desktop Technology Support", 300, 695),
                    InvoiceItem.Create("Desktop Technology Support", 987, 789)
                },
            }
            );

            //Invoice 7
            invoices.Add(new Invoice()
            {
                InvoiceDate = invoice.CalculateInvoiceDate(7, currentDate),
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(8, currentDate),
                InvoiceRefNumber = "invoice007",
                InvoiceItems = new List<InvoiceItem>()
                {
                    InvoiceItem.Create("After-hour maintenance", 250, 89),
                    InvoiceItem.Create("Security patches & CMS updates", 200, 400)
                },

            }
            );


            //Invoice 8
            invoices.Add(new Invoice()
            {
                InvoiceDate = invoice.CalculateInvoiceDate(8, currentDate),
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(9, currentDate),
                InvoiceRefNumber = "invoice008",
                InvoiceItems = new List<InvoiceItem>()
                {
                     InvoiceItem.Create("Desktop Technology Support", 300, 84),
                     InvoiceItem.Create("Desktop Technology Support", 200, 400),
                     InvoiceItem.Create("Desktop Technology Support", 479, 9876)
                },
            }
            );


            //Invoice 9
            invoices.Add(new Invoice()
            {
                InvoiceDate = invoice.CalculateInvoiceDate(9, currentDate),
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(10, currentDate),
                InvoiceRefNumber = "invoice009",
                InvoiceItems = new List<InvoiceItem>()
                {
                    InvoiceItem.Create("Full web maintenance", 960, 400),
                    InvoiceItem.Create("Full web maintenance", 450, 789)
                },
            }
            );


            //Invoice 10
            invoices.Add(new Invoice()
            {
                InvoiceDate = invoice.CalculateInvoiceDate(10, currentDate),
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(11, currentDate),
                InvoiceRefNumber = "invoice010",
                InvoiceItems = new List<InvoiceItem>()
                {
                    InvoiceItem.Create("Desktop Technology Support", 300, 84),
                    InvoiceItem.Create("Desktop Technology Support", 200, 400)
                },
            }
            );


            //Invoice 11
            invoices.Add(new Invoice()
            {
                InvoiceDate = invoice.CalculateInvoiceDate(11, currentDate),
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(12, currentDate),
                InvoiceRefNumber = "invoice011",
                InvoiceItems = new List<InvoiceItem>()
                {
                    InvoiceItem.Create("Desktop Technology Support", 300, 84),
                    InvoiceItem.Create("Desktop Technology Support", 200, 400)
                },
            }
            );

            //Invoice 12
            invoices.Add(new Invoice()
            {
                InvoiceDate = invoice.CalculateInvoiceDate(12, currentDate),
                InvoiceDueDate = invoice.CalculateInvoiceDueDate(13, currentDate),
                InvoiceRefNumber = "invoice012",
                InvoiceItems = new List<InvoiceItem>()
                {
                    InvoiceItem.Create("Desktop Technology Support", 300, 84),
                    InvoiceItem.Create("Desktop Technology Support", 200, 400)
                },
            }
            );

            return invoices;
        }
    }
}
