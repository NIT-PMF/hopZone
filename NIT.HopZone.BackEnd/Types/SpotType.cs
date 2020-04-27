using GraphQL.Types;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.Web.Types
{
    public class SpotType : ObjectGraphType<Spot>
    {
        public SpotType()
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field(_ => _.Description, type: typeof(StringGraphType));
            Field(_ => _.ImageURL, type: typeof(StringGraphType));
            Field(_ => _.Id_map_coordinate, type: typeof(StringGraphType));
            Field(_ => _.Id_city, type: typeof(StringGraphType));

        }

    }
}
