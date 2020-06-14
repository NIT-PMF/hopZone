using GraphQL.Types;
using NIT.HopZone.BackEnd.Data;
using NIT.HopZone.BackEnd.InputTypes;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Types;

namespace NIT.HopZone.Web.Repository
{
    public class NTPMutation : ObjectGraphType
    {
        public NTPMutation(ICollectionRepository<Role> adminRepository) // promjenili
        {

            Name = "Mutation";


            Field<RoleType>( // promjenili
              "createRole",
              arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<RoleInputType>> { Name = "role" }
              ),
              resolve: context =>
              {
                  var role = context.GetArgument<Role>("role"); //promjenili 

                  return adminRepository.insert(role);
              });
        }
    }
}