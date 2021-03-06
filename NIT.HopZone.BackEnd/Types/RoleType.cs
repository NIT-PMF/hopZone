﻿using GraphQL.Types;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.Web.Types
{
    public class RoleType : ObjectGraphType<Role>
    {
        public RoleType()
        {
            Field(_ => _.id, type: typeof(StringGraphType));
            Field(_ => _.Authority, type: typeof(IntGraphType)).Description("Each Account is given Authority 0 which can be changed");
        }
    }
}
