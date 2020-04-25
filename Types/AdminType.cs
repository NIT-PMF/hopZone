using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using HopZoneV2.Models;

namespace HopZoneV2.Types
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
            Field(_ => _.CreatedOn, type: typeof(DateTimeGraphType)).Description("Account created on");
            Field(_ => _.UpdatedOn, type: typeof(DateTimeGraphType)).Description("Account updated last on");

        }
    }
}
