using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var builder = new InvoiceBuilder();

            Invoice invoice = builder.SetDate(new DateTime(2020, 1, 1))
                .SetInvoiceNumber("A1")
                .SetVendor("Google..")
                .SetVendee("Vendee")
                .SetLineItems(new List<string>() {"Line item1", "Line item2" })
                .Build();

            Console.WriteLine(invoice.Vendee);
            Console.WriteLine(invoice.Vendor);

        }
    }
}
