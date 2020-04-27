using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.Web.Types
{
    public class RoleType : ObjectGraphType<Role>
    {
        public RoleType()
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field(_ => _.Authority, type: typeof(IntGraphType)).Description("Each Account is given Authority 0 which can be changed");
        }
    }
}
