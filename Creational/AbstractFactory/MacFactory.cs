using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MacFactory : IUIElementFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextbox CreateTextbox()
        {
            return new MacTextbox();
        }
    }
}
