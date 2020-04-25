using GraphQL.Types;
using HopZoneV2.Models;

namespace HopZoneV2.Repository
{
    public class CountryType : ObjectGraphType<Country>
    {
        public CountryType()
        {
            Field(country => country.Id, type: typeof(StringGraphType));
            Field(country => country.Id_country, type: typeof(IntGraphType));
            Field(country => country.Name, type: typeof(StringGraphType)).Description("Name of Country");
            Field(country => country.Code, type: typeof(StringGraphType)).Description("Country Code (if exists)");
        }
    }
}
