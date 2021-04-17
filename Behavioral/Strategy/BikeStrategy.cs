using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class BikeStrategy : IRouteStrategy
    {
        public void CreateRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine("Bike strategy");
        }
    }
}
