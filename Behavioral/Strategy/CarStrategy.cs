using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CarStrategy : IRouteStrategy
    {
        public void CreateRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine("Car strategy");
        }
    }
}
