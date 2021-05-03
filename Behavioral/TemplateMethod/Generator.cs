using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Generator
    {
        public void GenerateReport()
        {
            GetData();
            PrepareData();
            GenerateFile();
            SendFile();
        }
        protected virtual void GetData()
        {
            Console.WriteLine("Base get data");
        }

        protected abstract void PrepareData();
        protected abstract void GenerateFile();

        protected void SendFile()
        {
            Console.WriteLine("Sending generated report");
        }

    }
}
