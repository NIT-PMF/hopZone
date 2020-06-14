using GraphQL.Types;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.BackEnd.InputTypes
{
    public class AdminInputType : InputObjectGraphType<Role> // promjenili
    {
        public AdminInputType()
        {
            Name = "AdminInputType";

            Field<IntGraphType>("Authority");
            
        }
    }
}
