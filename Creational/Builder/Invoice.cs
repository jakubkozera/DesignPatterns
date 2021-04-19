using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Invoice
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public string Vendor { get; set; }
        public string Vendee { get; set; }
        public IEnumerable<string> LineItems { get; set; }
        public string Note { get; set; }
    }
}
