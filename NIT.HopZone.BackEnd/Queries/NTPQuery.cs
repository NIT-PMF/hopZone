
using System.Linq;
using GraphQL.Types;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Repository;
using NIT.HopZone.Web.Settings;
using NIT.HopZone.Web.Types;

namespace NIT.HopZone.Web.Queries
{
    public class NTPQuery : ObjectGraphType
    {
        public NTPQuery
        (
            ICollectionRepository<Country> countriesRepository,
            ICollectionRepository<Season> seasonsRepository,
            ICollectionRepository<Admin> adminsRepository
         )
        {

            Field<AdminType>
            (
                "admin",
                arguments: new QueryArguments
                (
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                    { Name = "code", Description = "Country code" }
                ),

                resolve: context => adminsRepository
                    .GetItemAsync("code", context.GetArgument<string>("code"))
                    .Result
            );

            Field<ListGraphType<AdminType>>
            (
                "admins",
                resolve: context => adminsRepository
                    .GetItemsAsync()
                    .Result
            );


            Field<CountryType>
            (
                "country",
                arguments: new QueryArguments
                (
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                    { Name = "code", Description = "Country code" }
                ),
                resolve: context => countriesRepository
                    .GetItemAsync("code", context.GetArgument<string>("code"))
                    .Result
            );

            Field<ListGraphType<CountryType>>
            (
                "countries",
                resolve: context => countriesRepository
                    .GetItemsAsync()
                    .Result
            );
        }
    }
}
