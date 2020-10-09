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
        public void CreateInvoicesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var expected = 12;

            //Act
            var actual = invoiceStore.CreateInvoices();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod()]
        public void InvoiceItemsExistTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var expected = true;

            //Act

            bool actual;

            if (invoiceStore.CreateInvoices()[0].InvoiceItems.Count < 0)
            {
             actual = false;
            }
            actual = true;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FirstInvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(1).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(2).AddDays(-1).ToString("dd/MM/yyyy");

            var expected =  invoiceDate +" "+ invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[0].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[0].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SecondInvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(2).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(3).AddDays(-1).ToString("dd/MM/yyyy");

            var expected = invoiceDate + " " + invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[1].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[1].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ThirdInvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(3).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(4).AddDays(-1).ToString("dd/MM/yyyy");

            var expected = invoiceDate + " " + invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[2].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[2].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FourthInvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(4).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(5).AddDays(-1).ToString("dd/MM/yyyy");

            var expected = invoiceDate + " " + invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[3].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[3].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FifthInvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(5).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(6).AddDays(-1).ToString("dd/MM/yyyy");

            var expected = invoiceDate + " " + invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[4].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[4].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SixthInvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(6).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(7).AddDays(-1).ToString("dd/MM/yyyy");

            var expected = invoiceDate + " " + invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[5].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[5].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SeventhInvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(7).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(8).AddDays(-1).ToString("dd/MM/yyyy");

            var expected = invoiceDate + " " + invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[6].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[6].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EighthInvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(8).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(9).AddDays(-1).ToString("dd/MM/yyyy");

            var expected = invoiceDate + " " + invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[7].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[7].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NinethInvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(9).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(10).AddDays(-1).ToString("dd/MM/yyyy");

            var expected = invoiceDate + " " + invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[8].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[8].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TengthInvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(10).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(11).AddDays(-1).ToString("dd/MM/yyyy");

            var expected = invoiceDate + " " + invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[9].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[9].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void EleventhInvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(11).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(12).AddDays(-1).ToString("dd/MM/yyyy");

            var expected = invoiceDate + " " + invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[10].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[10].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TwelfthInvoiceDatesTest()
        {
            //Arrange 
            var invoiceStore = new InvoiceStore();
            var now = DateTimeOffset.UtcNow;
            var currentDate = new DateTime(now.Year, now.Month, 1);

            var invoiceDate = currentDate.AddMonths(12).AddDays(-6).ToString("dd/MM/yyyy");
            var invoiceDueDate = currentDate.AddMonths(13).AddDays(-1).ToString("dd/MM/yyyy");

            var expected = invoiceDate + " " + invoiceDueDate;

            //Act

            var actualInvoiceDate = invoiceStore.CreateInvoices()[11].InvoiceDate;
            var actualInvoiceDueDate = invoiceStore.CreateInvoices()[11].InvoiceDueDate;

            var actual = actualInvoiceDate + " " + actualInvoiceDueDate;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalAmountOfFirstInvoiceTest()
        {
            //Arrange
            var invoiceStore = new InvoiceStore();

            var invoiceItem1RatePerHour = 400;
            var invoiceItem1HoursWorked = 84;

            var invoiceItem2RatePerHour = 365;
            var invoiceItem2HoursWorked = 91;

            var invoiceItem3RatePerHour = 200;
            var invoiceItem3HoursWorked = 400;


            var totalAmountCalculation = (invoiceItem1RatePerHour * invoiceItem1HoursWorked) + (invoiceItem2RatePerHour * invoiceItem2HoursWorked)
                            + (invoiceItem3RatePerHour * invoiceItem3HoursWorked);


            var expected = totalAmountCalculation.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
            //Act

            var actual = invoiceStore.CreateInvoices()[0].TotalInvoiceAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalAmountOfSecondInvoiceTest()
        {
            //Arrange
            var invoiceStore = new InvoiceStore();

            var invoiceItem1RatePerHour = 300;
            var invoiceItem1HoursWorked = 84;

            var invoiceItem2RatePerHour = 200;
            var invoiceItem2HoursWorked = 400;


            var totalAmountCalculation = (invoiceItem1RatePerHour * invoiceItem1HoursWorked) + (invoiceItem2RatePerHour * invoiceItem2HoursWorked);


            var expected = totalAmountCalculation.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
            //Act

            var actual = invoiceStore.CreateInvoices()[1].TotalInvoiceAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void CalculateTotalAmountOfThirdInvoiceTest()
        {
            //Arrange
            var invoiceStore = new InvoiceStore();

            var invoiceItem1RatePerHour = 487;
            var invoiceItem1HoursWorked = 84;

            var invoiceItem2RatePerHour = 265;
            var invoiceItem2HoursWorked = 578;

            var invoiceItem3RatePerHour = 987;
            var invoiceItem3HoursWorked = 78;

            var invoiceItem4RatePerHour = 1000;
            var invoiceItem4HoursWorked = 1200;


            var totalAmountCalculation = (invoiceItem1RatePerHour * invoiceItem1HoursWorked) + (invoiceItem2RatePerHour * invoiceItem2HoursWorked)
                            + (invoiceItem3RatePerHour * invoiceItem3HoursWorked) + (invoiceItem4RatePerHour * invoiceItem4HoursWorked);


            var expected = totalAmountCalculation.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
            //Act

            var actual = invoiceStore.CreateInvoices()[2].TotalInvoiceAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalAmountOfFourthInvoiceTest()
        {
            //Arrange
            var invoiceStore = new InvoiceStore();

            var invoiceItem1RatePerHour = 300;
            var invoiceItem1HoursWorked = 84;

            var invoiceItem2RatePerHour = 200;
            var invoiceItem2HoursWorked = 490;

            var invoiceItem3RatePerHour = 300;
            var invoiceItem3HoursWorked = 579;

            var totalAmountCalculation = (invoiceItem1RatePerHour * invoiceItem1HoursWorked) + (invoiceItem2RatePerHour * invoiceItem2HoursWorked)
                            + (invoiceItem3RatePerHour * invoiceItem3HoursWorked);


            var expected = totalAmountCalculation.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
            //Act

            var actual = invoiceStore.CreateInvoices()[3].TotalInvoiceAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalAmountOfFifthInvoiceTest()
        {
            //Arrange
            var invoiceStore = new InvoiceStore();

            var invoiceItem1RatePerHour = 300;
            var invoiceItem1HoursWorked = 84;

            var invoiceItem2RatePerHour = 200;
            var invoiceItem2HoursWorked = 400;

            var totalAmountCalculation = (invoiceItem1RatePerHour * invoiceItem1HoursWorked) 
                                         + (invoiceItem2RatePerHour * invoiceItem2HoursWorked);


            var expected = totalAmountCalculation.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
            //Act

            var actual = invoiceStore.CreateInvoices()[4].TotalInvoiceAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalAmountOfSixthInvoiceTest()
        {
            //Arrange
            var invoiceStore = new InvoiceStore();

            var invoiceItem1RatePerHour = 300;
            var invoiceItem1HoursWorked = 695;

            var invoiceItem2RatePerHour = 987;
            var invoiceItem2HoursWorked = 789;

            var totalAmountCalculation = (invoiceItem1RatePerHour * invoiceItem1HoursWorked)
                                         + (invoiceItem2RatePerHour * invoiceItem2HoursWorked);


            var expected = totalAmountCalculation.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
            //Act

            var actual = invoiceStore.CreateInvoices()[5].TotalInvoiceAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalAmountOfSeventhInvoiceTest()
        {
            //Arrange
            var invoiceStore = new InvoiceStore();

            var invoiceItem1RatePerHour = 250;
            var invoiceItem1HoursWorked = 89;

            var invoiceItem2RatePerHour = 200;
            var invoiceItem2HoursWorked = 400;

            var totalAmountCalculation = (invoiceItem1RatePerHour * invoiceItem1HoursWorked)
                                         + (invoiceItem2RatePerHour * invoiceItem2HoursWorked);


            var expected = totalAmountCalculation.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
            //Act

            var actual = invoiceStore.CreateInvoices()[6].TotalInvoiceAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalAmountOfEighthInvoiceTest()
        {
            //Arrange
            var invoiceStore = new InvoiceStore();

            var invoiceItem1RatePerHour = 300;
            var invoiceItem1HoursWorked = 84;

            var invoiceItem2RatePerHour = 200;
            var invoiceItem2HoursWorked = 400;

            var invoiceItem3RatePerHour = 479;
            var invoiceItem3HoursWorked = 9876;

            var totalAmountCalculation = (invoiceItem1RatePerHour * invoiceItem1HoursWorked)
                                         + (invoiceItem2RatePerHour * invoiceItem2HoursWorked) + (invoiceItem3RatePerHour * invoiceItem3HoursWorked);


            var expected = totalAmountCalculation.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
            //Act

            var actual = invoiceStore.CreateInvoices()[7].TotalInvoiceAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalAmountOfNinethInvoiceTest()
        {
            //Arrange
            var invoiceStore = new InvoiceStore();

            var invoiceItem1RatePerHour = 960;
            var invoiceItem1HoursWorked = 400;

            var invoiceItem2RatePerHour = 450;
            var invoiceItem2HoursWorked = 789;

            var totalAmountCalculation = (invoiceItem1RatePerHour * invoiceItem1HoursWorked)
                                         + (invoiceItem2RatePerHour * invoiceItem2HoursWorked);


            var expected = totalAmountCalculation.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
            //Act

            var actual = invoiceStore.CreateInvoices()[8].TotalInvoiceAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalAmountOfTenthInvoiceTest()
        {
            //Arrange
            var invoiceStore = new InvoiceStore();

            var invoiceItem1RatePerHour = 300;
            var invoiceItem1HoursWorked = 84;

            var invoiceItem2RatePerHour = 200;
            var invoiceItem2HoursWorked = 400;

            var totalAmountCalculation = (invoiceItem1RatePerHour * invoiceItem1HoursWorked)
                                         + (invoiceItem2RatePerHour * invoiceItem2HoursWorked);


            var expected = totalAmountCalculation.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
            //Act

            var actual = invoiceStore.CreateInvoices()[9].TotalInvoiceAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalAmountOfEleventhInvoiceTest()
        {
            //Arrange
            var invoiceStore = new InvoiceStore();

            var invoiceItem1RatePerHour = 300;
            var invoiceItem1HoursWorked = 84;

            var invoiceItem2RatePerHour = 200;
            var invoiceItem2HoursWorked = 400;

            var totalAmountCalculation = (invoiceItem1RatePerHour * invoiceItem1HoursWorked)
                                         + (invoiceItem2RatePerHour * invoiceItem2HoursWorked);


            var expected = totalAmountCalculation.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
            //Act

            var actual = invoiceStore.CreateInvoices()[10].TotalInvoiceAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTotalAmountOfTwelfthInvoiceTest()
        {
            //Arrange
            var invoiceStore = new InvoiceStore();

            var invoiceItem1RatePerHour = 300;
            var invoiceItem1HoursWorked = 84;

            var invoiceItem2RatePerHour = 200;
            var invoiceItem2HoursWorked = 400;

            var totalAmountCalculation = (invoiceItem1RatePerHour * invoiceItem1HoursWorked)
                                         + (invoiceItem2RatePerHour * invoiceItem2HoursWorked);


            var expected = totalAmountCalculation.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
            //Act

            var actual = invoiceStore.CreateInvoices()[11].TotalInvoiceAmount;

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}