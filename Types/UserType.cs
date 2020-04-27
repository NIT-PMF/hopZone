using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using HopZone.Models;

namespace NIT.HopZone.Web.Types
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field(_ => _.FirstName, type: typeof(StringGraphType));
            Field(_ => _.LastName, type: typeof(StringGraphType));
            Field(_ => _.Username, type: typeof(StringGraphType));
            Field(_ => _.Description, type: typeof(StringGraphType)).Description("Optional Description of User");
            Field(_ => _.Email, type: typeof(StringGraphType));
            Field(_ => _.Password, type: typeof(StringGraphType));
            Field(_ => _.CreatedOn, type: typeof(IntGraphType)).Description("DateTime when Account was created");
            Field(_ => _.Active, type: typeof(BooleanGraphType)).Description("Is Account Active");
            Field<CityType>(nameof(User.City));
            Field<GenderType>(nameof(User.Gender));
            Field<RoleType>(nameof(User.Role));
        }
    }
}
