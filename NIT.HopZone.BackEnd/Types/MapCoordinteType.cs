using GraphQL.Types;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.Web.Types
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
