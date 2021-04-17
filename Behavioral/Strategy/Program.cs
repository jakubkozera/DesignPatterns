using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var strategy = new CarStrategy();

            var map = new Map(strategy);

            var start = new Coordinate();
            var end = new Coordinate();

            map.CreateRoute(start, end);
        }
    }
}
