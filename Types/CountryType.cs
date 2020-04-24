using GraphQL.Types;
using HopZoneV2.Models;

namespace HopZoneV2.Repository
{
    public class CountryType : ObjectGraphType<Country>
    {
        public CountryType(ICollectionRepository<Season> seasonsRepository)
        {
            Field(country => country.Id, type: typeof(StringGraphType));
            Field(country => country.Id_country, type: typeof(IntGraphType));
            Field(country => country.Name, type: typeof(StringGraphType));
            Field(country => country.Code, type: typeof(StringGraphType));
            
            Field<ListGraphType<SeasonType>>(
               "seasons",
               resolve: context => seasonsRepository
                   .GetItemsAsync("Id_country", context.Source.Id_country)
                   .Result
            );
        }
    }
}
