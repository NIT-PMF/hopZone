using GraphQL.Types;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Repository;

namespace NIT.HopZone.Web.Types
{
    public class CityType : ObjectGraphType<City>
    {
        public CityType()
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field(_ => _.Name, type: typeof(IntGraphType)).Description("Name of the City");
            Field(_ => _.Code, type: typeof(StringGraphType)).Description("Postal Code of City (if available) ");
            Field<CountryType>(nameof(City.Country));
        }
    }
}
