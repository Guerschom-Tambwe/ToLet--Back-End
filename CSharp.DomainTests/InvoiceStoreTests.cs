using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CSharp.Domain.Tests
{
    [TestClass()]
    public class InvoiceStoreTests
    {

        [TestMethod()]
        public void TestTotalInvoiceItemAmount()
        {
            //Arrange 
            var invItem = InvoiceItem.Create("", 100, 25);

            //Assert
            Assert.AreEqual(invItem.TotalAmount, 255);
        }

        [TestMethod()]
        public void InvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(1).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(2).AddDays(-1).ToString("dd/MM/yyyy");

            var expected = invoiceDate + " " + invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[0].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[0].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}