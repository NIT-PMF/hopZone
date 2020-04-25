using GraphQL.Types;
using HopZoneV2.Models;
using HopZoneV2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Types
{
    public class RouteType : ObjectGraphType<Route>
    {
        public RouteType(ICollectionRepository<Route> routeRepository)
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field(_ => _.description, type: typeof(StringGraphType));
            Field(_ => _.name, type: typeof(StringGraphType));
            Field(_ => _.time_posted, type: typeof(TimeSpanSecondsGraphType));
            Field(_ => _.Id_spots, type: typeof(ListGraphType<StringGraphType>));
            Field(_ => _.Id_city, type: typeof(StringGraphType));

        }

    }
}