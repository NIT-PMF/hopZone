using GraphQL.Types;

namespace NIT.HopZone.BackEnd.InputTypes
{
    public class ContactInputType : InputObjectGraphType
    {
        public ContactInputType()
        {
            Name = "ContactInputType";

            Field<NonNullGraphType<StringGraphType>>("Username");
            Field<NonNullGraphType<StringGraphType>>("Subject");
            Field<NonNullGraphType<StringGraphType>>("Body");
            Field<NonNullGraphType<StringGraphType>>("Email");
        }
    }
}
