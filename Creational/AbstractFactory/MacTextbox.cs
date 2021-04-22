using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MacTextbox : ITextbox
    {
        public void Render()
        {
            Console.WriteLine("Render Mac textbox");
        }

        public void HandleInput()
        {
            Console.WriteLine("Handle Mac text input");
        }
    }
}
