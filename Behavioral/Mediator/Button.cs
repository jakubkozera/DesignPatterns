using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Button : Component
    {
        public void Render()
        {
            Console.WriteLine("Render button");
        }

        public void Click()
        {
            Console.WriteLine("Button click");

            this._mediator.Notify(this, "click");
        }
    }
}
