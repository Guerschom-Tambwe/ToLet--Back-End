using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CSharp.Domain
{
    public class InvoiceAmountsCalculations
    {
        public static void calculateItemPrices(List<InvoiceItem> items)
        {

            for (var i = 0; i < items.Count; i++)
            {
                items[i].Amount = items[i].RatePerHour * items[i].HoursWorked;
            }

        }

        public static void calculateTotalAmountPerInvoice(int invoicePosition, List<Invoice> invoiceDetails, List<InvoiceItem> items)
        {
            double calculationHolder = 0;

            for (var i = 0; i < items.Count; i++)
            {
                calculationHolder += items[i].Amount;

                if (i == items.Count - 1)
                    invoiceDetails[invoicePosition]
                        .TotalInvoiceAmount = calculationHolder.ToString("C", CultureInfo.GetCultureInfo("en-ZA"));
                                                    //using cultureInfo above to format amount to a currency (Rand)
            }
        }
    }
}
