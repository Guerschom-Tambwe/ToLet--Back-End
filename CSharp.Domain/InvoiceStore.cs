using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Domain
{
    public class InvoiceStore
    {
        public List<Invoice> CreateInvoices()
        {
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoices = new List<Invoice>();


            //Invoice 1
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(1).AddDays(-6).ToString("dd/MM/yyyy"),
                InvoiceRefNumber = "invoice001",
                InvoiceDueDate = currentDate.AddMonths(2).AddDays(-1).ToString("dd/MM/yyyy"),
                InvoiceItems = new List<InvoiceItem>()
                //The RatePerHour and HoursWorked are meant to be interpolated or concatenated with the description when displayed
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 400, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Network/Server Technolody Support", RatePerHour = 365, HoursWorked = 91},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400}
                },
            }
                );

            //TotalInvoiceAmount is set automatically after invoice items are provided 

            //Calculating and setting price per item(s) (Amount)
            InvoiceAmountsCalculations.CalculateItemPrices(invoices[0].InvoiceItems);

            //Calculating and setting total Amount Due(TotalInvoiceAmount) for invoice
            InvoiceAmountsCalculations.CalculateTotalAmountPerInvoice(0, invoices, invoices[0].InvoiceItems);


            //Invoice 2
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(2).AddDays(-6).ToString("dd/MM/yyyy"),
                InvoiceRefNumber = "invoice002",
                InvoiceDueDate = currentDate.AddMonths(3).AddDays(-1).ToString("dd/MM/yyyy"),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 300, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400}
                },
            }
            );

            InvoiceAmountsCalculations.CalculateItemPrices(invoices[1].InvoiceItems);
            InvoiceAmountsCalculations.CalculateTotalAmountPerInvoice(1, invoices, invoices[1].InvoiceItems);


            //Invoice 3
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(3).AddDays(-6).ToString("dd/MM/yyyy"),
                InvoiceRefNumber = "invoice003",
                InvoiceDueDate = currentDate.AddMonths(4).AddDays(-1).ToString("dd/MM/yyyy"),
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

            InvoiceAmountsCalculations.CalculateItemPrices(invoices[2].InvoiceItems);
            InvoiceAmountsCalculations.CalculateTotalAmountPerInvoice(2, invoices, invoices[2].InvoiceItems);


            //Invoice 4
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(4).AddDays(-6).ToString("dd/MM/yyyy"),
                InvoiceRefNumber = "invoice004",
                InvoiceDueDate = currentDate.AddMonths(5).AddDays(-1).ToString("dd/MM/yyyy"),
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

            InvoiceAmountsCalculations.CalculateItemPrices(invoices[3].InvoiceItems);
            InvoiceAmountsCalculations.CalculateTotalAmountPerInvoice(3, invoices, invoices[3].InvoiceItems);


            //Invoice 5
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(5).AddDays(-6).ToString("dd/MM/yyyy"),
                InvoiceRefNumber = "invoice005",
                InvoiceDueDate = currentDate.AddMonths(6).AddDays(-1).ToString("dd/MM/yyyy"),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Premier Consulting Services", RatePerHour = 300, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 200, HoursWorked = 400}
                },
            }
            );

            InvoiceAmountsCalculations.CalculateItemPrices(invoices[4].InvoiceItems);
            InvoiceAmountsCalculations.CalculateTotalAmountPerInvoice(4, invoices, invoices[4].InvoiceItems);


            //Invoice 6
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(6).AddDays(-6).ToString("dd/MM/yyyy"),
                InvoiceRefNumber = "invoice006",
                InvoiceDueDate = currentDate.AddMonths(7).AddDays(-1).ToString("dd/MM/yyyy"),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 300, HoursWorked = 695},
                    new InvoiceItem()
                      { Description = "Full web maintenance", RatePerHour = 987, HoursWorked = 789}
                },
            }
            );

            InvoiceAmountsCalculations.CalculateItemPrices(invoices[5].InvoiceItems);
            InvoiceAmountsCalculations.CalculateTotalAmountPerInvoice(5, invoices, invoices[5].InvoiceItems);


            //Invoice 7
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(7).AddDays(-6).ToString("dd/MM/yyyy"),
                InvoiceRefNumber = "invoice007",
                InvoiceDueDate = currentDate.AddMonths(8).AddDays(-1).ToString("dd/MM/yyyy"),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "After-hour maintenance", RatePerHour = 250, HoursWorked = 89},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400}
                },

            }
            );
            InvoiceAmountsCalculations.CalculateItemPrices(invoices[6].InvoiceItems);
            InvoiceAmountsCalculations.CalculateTotalAmountPerInvoice(6, invoices, invoices[6].InvoiceItems);


            //Invoice 8
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(8).AddDays(-6).ToString("dd/MM/yyyy"),
                InvoiceRefNumber = "invoice008",
                InvoiceDueDate = currentDate.AddMonths(9).AddDays(-1).ToString("dd/MM/yyyy"),
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

            InvoiceAmountsCalculations.CalculateItemPrices(invoices[7].InvoiceItems);
            InvoiceAmountsCalculations.CalculateTotalAmountPerInvoice(7, invoices, invoices[7].InvoiceItems);


            //Invoice 9
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(9).AddDays(-6).ToString("dd/MM/yyyy"),
                InvoiceRefNumber = "invoice009",
                InvoiceDueDate = currentDate.AddMonths(10).AddDays(-1).ToString("dd/MM/yyyy"),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Full web maintenance", RatePerHour = 960, HoursWorked = 400},
                    new InvoiceItem()
                      { Description = "After-hour maintenance", RatePerHour = 450, HoursWorked = 789}
                },
            }
            );

            InvoiceAmountsCalculations.CalculateItemPrices(invoices[8].InvoiceItems);
            InvoiceAmountsCalculations.CalculateTotalAmountPerInvoice(8, invoices, invoices[8].InvoiceItems);


            //Invoice 10
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(10).AddDays(-6).ToString("dd/MM/yyyy"),
                InvoiceRefNumber = "invoice010",
                InvoiceDueDate = currentDate.AddMonths(11).AddDays(-1).ToString("dd/MM/yyyy"),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 300, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400}
                },
            }
            );

            InvoiceAmountsCalculations.CalculateItemPrices(invoices[9].InvoiceItems);
            InvoiceAmountsCalculations.CalculateTotalAmountPerInvoice(9, invoices, invoices[9].InvoiceItems);


            //Invoice 11
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(11).AddDays(-6).ToString("dd/MM/yyyy"),
                InvoiceRefNumber = "invoice011",
                InvoiceDueDate = currentDate.AddMonths(12).AddDays(-1).ToString("dd/MM/yyyy"),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 300, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400}
                },
            }
            );

            InvoiceAmountsCalculations.CalculateItemPrices(invoices[10].InvoiceItems);
            InvoiceAmountsCalculations.CalculateTotalAmountPerInvoice(10, invoices, invoices[10].InvoiceItems);

            //Invoice 12
            invoices.Add(new Invoice()
            {
                InvoiceDate = currentDate.AddMonths(12).AddDays(-6).ToString("dd/MM/yyyy"),
                InvoiceRefNumber = "invoice012",
                InvoiceDueDate = currentDate.AddMonths(13).AddDays(-1).ToString("dd/MM/yyyy"),
                InvoiceItems = new List<InvoiceItem>()
                {
                    new InvoiceItem()
                      { Description = "Desktop Technology Support", RatePerHour = 300, HoursWorked = 84},
                    new InvoiceItem()
                      { Description = "Security patches & CMS updates", RatePerHour = 200, HoursWorked = 400}
                },
            }
            );

            InvoiceAmountsCalculations.CalculateItemPrices(invoices[11].InvoiceItems);
            InvoiceAmountsCalculations.CalculateTotalAmountPerInvoice(11, invoices, invoices[11].InvoiceItems);

            return invoices;
        }
    }
}
