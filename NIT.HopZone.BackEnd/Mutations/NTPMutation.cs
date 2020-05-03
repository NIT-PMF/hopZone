using GraphQL.Types;
using NIT.HopZone.BackEnd.Data;
using NIT.HopZone.BackEnd.InputTypes;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Types;

namespace NIT.HopZone.Web.Repository
{
    public class NTPMutation : ObjectGraphType
    {
        public NTPMutation(HopZoneData data)
        {
            Name = "Mutation";

            Field<AdminType>(
              "createAdmin",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<AdminInputType>> { Name = "admin" }
              ),
              resolve: context =>
              {
                  var admin = context.GetArgument<Admin>("admin");
                  return data.AddAdmin(admin);
              });
        }
    }
}