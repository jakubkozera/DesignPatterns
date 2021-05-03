using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class PdfGenerator : Generator
    {
        protected override void GetData()
        {
            Console.WriteLine("Pdf get data override");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for pdf");
        }

        protected override void GenerateFile()
        {
            Console.WriteLine("Generate pdf file");
        }
    }
}
