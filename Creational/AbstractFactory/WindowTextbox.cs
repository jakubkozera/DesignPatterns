using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WindowTextbox : ITextbox
    {
        public void Render()
        {
            Console.WriteLine("Render windows textbox");
        }

        public void HandleInput()
        {
            Console.WriteLine("Handle windows text input");
        }
    }
}
