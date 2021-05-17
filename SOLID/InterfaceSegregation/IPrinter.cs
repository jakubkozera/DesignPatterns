using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IPrinter
    {
        void PrintGrey(string content);
        void PrintColor(string content);
    }

    public interface IScanner
    {
        void Scan(string content);

    }

    public interface IFaxContent
    {
        void Fax(string content);

    }
}
