using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class Cannon : IPrinter, IFaxContent
    {
        public void PrintGrey(string content)
        {
            Console.WriteLine("Cannon print grey");
        }

        public void PrintColor(string content)
        {
            Console.WriteLine("Cannon print color");
        }
        public void Fax(string content)
        {
            Console.WriteLine("Cannon print fax");
        }
    }
}
