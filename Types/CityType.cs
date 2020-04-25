using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using HopZoneV2.Models;
using HopZoneV2.Repository;

namespace HopZoneV2.Types
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
