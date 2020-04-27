using GraphQL.Types;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Types
{
    public class PostType : ObjectGraphType<Post>
    {
        public PostType()
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field(_ => _.Description, type: typeof(StringGraphType));
            Field(_ => _.Name, type: typeof(StringGraphType));
            Field(_ => _.Id_comments, type: typeof(ListGraphType<StringGraphType>));
            Field(_ => _.Id_user, type: typeof(StringGraphType));
            Field(_ => _.Id_routes, type: typeof(ListGraphType<StringGraphType>));
            Field(_ => _.Like, type: typeof(IntGraphType));
            Field(_ => _.TimeCreated, type: typeof(DateGraphType));

        }

    }
}