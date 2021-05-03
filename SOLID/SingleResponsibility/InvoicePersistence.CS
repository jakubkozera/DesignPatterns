using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class InvoicePersistence
    {
        private Invoice _invoice;

        public InvoicePersistence(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void SaveToPdf()
        {
            Console.WriteLine("Saving to pdf");
        }
    }
}
