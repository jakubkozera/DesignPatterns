using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Render Mac button");
        }

        public void HandleClick()
        {
            Console.WriteLine("Handle Mac click event");
        }
    }
}
