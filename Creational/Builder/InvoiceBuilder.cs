using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class InvoiceBuilder
    {
        private Invoice _invoice = new Invoice();

        public Invoice Build()
        {
            return _invoice;
        }

        public InvoiceBuilder SetVendor(string vendor)
        {
            _invoice.Vendor = vendor;

            return this;
        }
        public InvoiceBuilder SetVendee(string vendee)
        {
            _invoice.Vendee = vendee;
            return this;

        }

        public InvoiceBuilder SetNote(string note)
        {
            _invoice.Note = note;
            return this;
        }

        public InvoiceBuilder SetLineItems(IEnumerable<string> lineItems)
        {
            _invoice.LineItems = lineItems;
            return this;
        }

        public InvoiceBuilder SetInvoiceNumber(string number)
        {
            _invoice.Number = number;
            return this;
        }

        public InvoiceBuilder SetDate(DateTime date)
        {
            _invoice.Date = date;
            return this;
        }
    }
}
