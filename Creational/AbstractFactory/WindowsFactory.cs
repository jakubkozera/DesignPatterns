using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WindowsFactory : IUIElementFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextbox CreateTextbox()
        {
            return new WindowTextbox();
        }
    }
}
