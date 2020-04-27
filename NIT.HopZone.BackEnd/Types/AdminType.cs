using GraphQL.Types;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.Web.Types
{
    public class AdminType : ObjectGraphType<Admin>
    {
        public AdminType()
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field(_ => _.FirstName, type: typeof(IntGraphType));
            Field(_ => _.LastName, type: typeof(StringGraphType));
            Field(_ => _.Username, type: typeof(StringGraphType)).Description("Unique Username");
            Field(_ => _.Email, type: typeof(StringGraphType)).Description("Unique Email");
            Field(_ => _.Password, type: typeof(StringGraphType));
            Field(_ => _.CreatedOn, false, type: typeof(NonNullGraphType<DateTimeGraphType>)).Description("Account created on");
            Field(_ => _.UpdatedOn, false, type: typeof(NonNullGraphType<DateTimeGraphType>)).Description("Account updated last on");

        }
    }
}
