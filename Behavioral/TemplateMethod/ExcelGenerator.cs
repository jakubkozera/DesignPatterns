using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ExcelGenerator : Generator
    {
        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for excel");
        }

        protected override void GenerateFile()
        {
            Console.WriteLine("Generate excel file");
        }
    }
}
