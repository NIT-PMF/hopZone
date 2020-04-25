using GraphQL.Types;
using HopZoneV2.Models;
using HopZoneV2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Types
{
    public class MapCoordinteType : ObjectGraphType<MapCoordinate>
    {
        public MapCoordinteType()
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field(_ => _.Longitude, type: typeof(IntGraphType));
            Field(_ => _.Latitude, type: typeof(IntGraphType));
            
        }

    }
    
}
