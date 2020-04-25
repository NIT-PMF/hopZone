using GraphQL.Types;
using HopZoneV2.Models;
using HopZoneV2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Types
{
    public class CommentType : ObjectGraphType<Comment>
    {
        public CommentType()
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field(_ => _.Body, type: typeof(StringGraphType));
            Field(_ => _.Like, type: typeof(IntGraphType));
            Field(_ => _.TimeWritten, type: typeof(DateGraphType));
            Field(_ => _.Id_post, type: typeof(StringGraphType));
            Field(_ => _.Id_user, type: typeof(StringGraphType));

        }

    }
}