using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharp.Domain;

namespace CSharp.App
{
    class Program
    {
        static void Main(string[] args)
        {

            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoices = new List<Invoice>();


            //Invoice 1
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(1).AddDays(-6).ToShortDateString(), 
                InvoiceRefNumber = "invoice001", 
                InvoiceDueDate = currentDate.AddMonths(2).AddDays(-1).ToShortDateString(),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 400, HoursWorked = 84},
                    new InvoiceItem() 
                      { Description = "Network/Server Technolody Support", RatePerHour = 365, HoursWorked = 91},
                    new InvoiceItem() 
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400}
                },
                //TotalInvoiceAmount is set automatically after invoice items are provided 
            }        
                );
            //Calculating and setting price per item(s) (Amount)
            InvoiceAmountsCalculations.calculateItemPrices(invoices[0].InvoiceItems);
            //Calculating and setting total Amount Due(TotalInvoiceAmount) for invoice
            InvoiceAmountsCalculations.calculateTotalAmountPerInvoice(0, invoices, invoices[0].InvoiceItems);

            
            //Invoice 2
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(2).AddDays(-6).ToShortDateString(),
                InvoiceRefNumber = "invoice002",
                InvoiceDueDate = currentDate.AddMonths(3).AddDays(-1).ToShortDateString(),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 300, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400}
                }, 
            }
            );

            InvoiceAmountsCalculations.calculateItemPrices(invoices[1].InvoiceItems);
            InvoiceAmountsCalculations.calculateTotalAmountPerInvoice(1, invoices, invoices[1].InvoiceItems);


            //Invoice 3
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(3).AddDays(-6).ToShortDateString(),
                InvoiceRefNumber = "invoice003",
                InvoiceDueDate = currentDate.AddMonths(4).AddDays(-1).ToShortDateString(),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Advanced Technology Support", RatePerHour = 487, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Premier Consulting services", RatePerHour = 265, HoursWorked = 578},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 987, HoursWorked = 78},
                    new InvoiceItem()
                      { Description = "After-hours maintenance", RatePerHour = 1000, HoursWorked = 1200}
                },
                
            }
            );

            InvoiceAmountsCalculations.calculateItemPrices(invoices[2].InvoiceItems);
            InvoiceAmountsCalculations.calculateTotalAmountPerInvoice(2, invoices, invoices[2].InvoiceItems);


            //Invoice 4
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(4).AddDays(-6).ToShortDateString(),
                InvoiceRefNumber = "invoice004",
                InvoiceDueDate = currentDate.AddMonths(5).AddDays(-1).ToShortDateString(),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Full web maintenance", RatePerHour = 300, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 490},
                    new InvoiceItem()
                      { Description = "Network/Server Technology", RatePerHour = 300, HoursWorked = 579}
                },
            }
            );

            InvoiceAmountsCalculations.calculateItemPrices(invoices[3].InvoiceItems);
            InvoiceAmountsCalculations.calculateTotalAmountPerInvoice(3, invoices, invoices[3].InvoiceItems);


            //Invoice 5
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(5).AddDays(-6).ToShortDateString(),
                InvoiceRefNumber = "invoice005",
                InvoiceDueDate = currentDate.AddMonths(6).AddDays(-1).ToShortDateString(),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Premier Consulting Services", RatePerHour = 300, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 200, HoursWorked = 400}
                },
            }
            );

            InvoiceAmountsCalculations.calculateItemPrices(invoices[4].InvoiceItems);
            InvoiceAmountsCalculations.calculateTotalAmountPerInvoice(4, invoices, invoices[4].InvoiceItems);


            //Invoice 6
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(6).AddDays(-6).ToShortDateString(),
                InvoiceRefNumber = "invoice006",
                InvoiceDueDate = currentDate.AddMonths(7).AddDays(-1).ToShortDateString(),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 300, HoursWorked = 695},
                    new InvoiceItem()
                      { Description = "Full web maintenance", RatePerHour = 987, HoursWorked = 789}
                },
            }
            );

            InvoiceAmountsCalculations.calculateItemPrices(invoices[5].InvoiceItems);
            InvoiceAmountsCalculations.calculateTotalAmountPerInvoice(5, invoices, invoices[5].InvoiceItems);


            //Invoice 7
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(7).AddDays(-6).ToShortDateString(),
                InvoiceRefNumber = "invoice007",
                InvoiceDueDate = currentDate.AddMonths(8).AddDays(-1).ToShortDateString(),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "After-hour maintenance", RatePerHour = 250, HoursWorked = 89},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400}
                },

            }
            );
            InvoiceAmountsCalculations.calculateItemPrices(invoices[6].InvoiceItems);
            InvoiceAmountsCalculations.calculateTotalAmountPerInvoice(6, invoices, invoices[6].InvoiceItems);


            //Invoice 8
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(8).AddDays(-6).ToShortDateString(),
                InvoiceRefNumber = "invoice008",
                InvoiceDueDate = currentDate.AddMonths(9).AddDays(-1).ToShortDateString(),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 300, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400},
                    new InvoiceItem()
                      { Description = "Network/Server Technology", RatePerHour = 479, HoursWorked = 9876}
                },
            }
            );

            InvoiceAmountsCalculations.calculateItemPrices(invoices[7].InvoiceItems);
            InvoiceAmountsCalculations.calculateTotalAmountPerInvoice(7, invoices, invoices[7].InvoiceItems);


            //Invoice 9
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(9).AddDays(-6).ToShortDateString(),
                InvoiceRefNumber = "invoice009",
                InvoiceDueDate = currentDate.AddMonths(10).AddDays(-1).ToShortDateString(),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Full web maintenance", RatePerHour = 960, HoursWorked = 400},
                    new InvoiceItem()
                      { Description = "After-hour maintenance", RatePerHour = 450, HoursWorked = 789}
                },
            }
            );

            InvoiceAmountsCalculations.calculateItemPrices(invoices[8].InvoiceItems);
            InvoiceAmountsCalculations.calculateTotalAmountPerInvoice(8, invoices, invoices[8].InvoiceItems);


            //Invoice 10
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(10).AddDays(-6).ToShortDateString(),
                InvoiceRefNumber = "invoice010",
                InvoiceDueDate = currentDate.AddMonths(11).AddDays(-1).ToShortDateString(),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 300, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400}
                }, 
            }
            );

            InvoiceAmountsCalculations.calculateItemPrices(invoices[9].InvoiceItems);
            InvoiceAmountsCalculations.calculateTotalAmountPerInvoice(9, invoices, invoices[9].InvoiceItems);


            //Invoice 11
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(11).AddDays(-6).ToShortDateString(),
                InvoiceRefNumber = "invoice011",
                InvoiceDueDate = currentDate.AddMonths(12).AddDays(-1).ToShortDateString(),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 300, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400}
                },
            }
            );

            InvoiceAmountsCalculations.calculateItemPrices(invoices[10].InvoiceItems);
            InvoiceAmountsCalculations.calculateTotalAmountPerInvoice(10, invoices, invoices[10].InvoiceItems);

            //Invoice 12
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(12).AddDays(-6).ToShortDateString(),
                InvoiceRefNumber = "invoice012",
                InvoiceDueDate = currentDate.AddMonths(13).AddDays(-1).ToShortDateString(),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 300, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400}
                },
            }
            );

            InvoiceAmountsCalculations.calculateItemPrices(invoices[11].InvoiceItems);
            InvoiceAmountsCalculations.calculateTotalAmountPerInvoice(11, invoices, invoices[11].InvoiceItems);

            foreach (var item in invoices)
            {
                Console.WriteLine(item.InvoiceDate);
                
            }
        }
    }
}
