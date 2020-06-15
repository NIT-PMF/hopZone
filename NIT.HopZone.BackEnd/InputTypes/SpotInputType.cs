
using GraphQL.Types;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.BackEnd.InputTypes
{
    public class SpotInputType : InputObjectGraphType // promjenili
    {
        public SpotInputType()
        {
            Name = "SpotInputType";

            Field<StringGraphType>("Description");

            Field<StringGraphType>("Id_map_coordinate");

            Field<StringGraphType>("ImageURL");

            Field<StringGraphType>("Id_city");

            Field<StringGraphType>("logitude");

            Field<StringGraphType>("latitude");
        }
    }
}
