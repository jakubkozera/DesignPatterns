using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Checkbox : Component
    {
        public void Select()
        {
            Console.WriteLine("checkbox selected");

            this._mediator.Notify(this, "checkboxSelected");
        }

        public void SaveValue()
        {
            Console.WriteLine("Checkbox value saved");
        }
    }
}
