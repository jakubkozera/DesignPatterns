using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Map
    {
        private IRouteStrategy _routeStrategy;

        public Map(IRouteStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }

        public void CreateRoute(Coordinate start, Coordinate end)
        {
            _routeStrategy.CreateRoute(start, end);
        }
    }
}
