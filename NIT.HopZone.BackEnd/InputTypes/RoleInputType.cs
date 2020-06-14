
using GraphQL.Types;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.BackEnd.InputTypes
{
    public class RoleInputType : InputObjectGraphType // promjenili
    {
        public RoleInputType()
        {
            Name = "RoleInputType";

            Field<IntGraphType>("Authority");
   
        }
    }
}
