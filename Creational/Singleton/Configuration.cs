using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Configuration
    {
        private static Configuration _instance = null;
        private static object obj = new object();
        public string StringProperty { get; set; }
        public int IntProperty { get; set; }

        private Configuration()
        {
        }

        public static Configuration GetInstance()
        {
            lock (obj)
            {
                if (_instance == null)
                {
                    _instance = new Configuration();
                }
            }


            return _instance;
        }

    }
}
