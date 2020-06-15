
using GraphQL.Types;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.BackEnd.InputTypes
{
    public class RouteInputType : InputObjectGraphType // promjenili
    {
        public RouteInputType()
        {
            Name = "RouteInputType";

            Field<StringGraphType>("Name");
            Field<StringGraphType>("Description");
            Field<IntGraphType>("Id_city");
            Field<StringGraphType>("ImageURL");
        }
    }
}
