using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var cfg = Configuration.GetInstance();
            var cfg2 = Configuration.GetInstance();

            if (ReferenceEquals(cfg, cfg2))
            {
                Console.WriteLine("Configuration is a singleton");
            }
        }
    }
}
