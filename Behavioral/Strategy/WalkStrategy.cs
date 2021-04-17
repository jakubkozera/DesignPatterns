using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class WalkStrategy : IRouteStrategy
    {
        public void CreateRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine("Walk strategy");
        }
    }
}
