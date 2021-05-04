using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Class
{
    public interface IInvoiceSaver
    {
        void Save(Invoice invoice);
    }
}
