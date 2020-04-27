using GraphQL.Types;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.Web.Repository
{
    public class SeasonType : ObjectGraphType<Season>
    {
        public SeasonType(ITeamsCollectionRepository<Fixture> fixturesRepository)
        {
            Field(season => season.Id, type: typeof(StringGraphType));
            Field(season => season.Id_country, type: typeof(IntGraphType));
            Field(season => season.Id_league, type: typeof(IntGraphType));
            Field(season => season.Id_season, type: typeof(IntGraphType));
            Field(season => season.Name, type: typeof(StringGraphType));
            Field(season => season.Years, type: typeof(StringGraphType));

            Field<ListGraphType<FixtureType>>(
              "fixtures",
              resolve: context => fixturesRepository
                   .GetItemsAsync("Id_season", context.Source.Id_season).Result
            );
        }
    }
}
