using GraphQL.Types;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.BackEnd.InputTypes
{
    public class AdminInputType : InputObjectGraphType<Admin>
    {
        public AdminInputType()
        {
            Name = "AdminInputType";
            Field<StringGraphType>("FirstName");
            Field<StringGraphType>("LastName");
            Field<StringGraphType>("Username");
            Field<StringGraphType>("Email");
            Field<StringGraphType>("Password");

        }
    }
}
