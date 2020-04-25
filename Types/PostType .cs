using GraphQL.Types;
using HopZoneV2.Models;
using HopZoneV2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Types
{
    public class PostType : ObjectGraphType<Post>
    {
        public PostType(ICollectionRepository<Post> postRepository)
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field(_ => _.description, type: typeof(StringGraphType));
            Field(_ => _.name, type: typeof(StringGraphType));
            Field(_ => _.Id_comments, type: typeof(ListGraphType<StringGraphType>));
            Field(_ => _.Id_user, type: typeof(StringGraphType));
            Field(_ => _.Id_routes, type: typeof(ListGraphType<StringGraphType>));
            Field(_ => _.lajk, type: typeof(IntGraphType));
            Field(_ => _.time_created, type: typeof(TimeSpanSecondsGraphType));

        }

    }
}