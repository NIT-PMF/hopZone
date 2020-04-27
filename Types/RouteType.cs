using GraphQL.Types;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Types
{
    public class RouteType : ObjectGraphType<Route>
    {
        public RouteType()
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field(_ => _.Description, type: typeof(StringGraphType));
            Field(_ => _.Name, type: typeof(StringGraphType));
            Field(_ => _.TimePosted, type: typeof(DateTimeGraphType));
            Field(_ => _.Id_spots, type: typeof(ListGraphType<StringGraphType>));
            Field(_ => _.Id_city, type: typeof(StringGraphType));

        }

    }
}