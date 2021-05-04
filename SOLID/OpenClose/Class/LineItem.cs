using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    public class LineItem
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }
        public int TaxRate { get; set; }
    }
}
