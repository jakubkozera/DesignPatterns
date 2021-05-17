using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class SecurityScanner
    {
        public IEnumerable<string> SecurityScan(string githubUrl)
        {
            Console.WriteLine("Security scan");

            return new List<string>() { "security error1"};
        }
    }
}
