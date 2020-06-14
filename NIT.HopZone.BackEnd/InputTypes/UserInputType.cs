using GraphQL.Types;

namespace NIT.HopZone.BackEnd.InputTypes
{
    public class UserInputType : InputObjectGraphType
    {
        public UserInputType()
        {
            Name = "UserInput";

            Field<NonNullGraphType<StringGraphType>>("FirstName");
            Field<NonNullGraphType<StringGraphType>>("LastName");
            Field<NonNullGraphType<StringGraphType>>("Username");
            Field<StringGraphType>("Description");
            Field<NonNullGraphType<StringGraphType>>("Email");
            Field<NonNullGraphType<StringGraphType>>("Password");
            Field<NonNullGraphType<StringGraphType>>("City");
            Field<NonNullGraphType<StringGraphType>>("Gender");
            Field<NonNullGraphType<IntGraphType>>("Role");
        }
    }
}
