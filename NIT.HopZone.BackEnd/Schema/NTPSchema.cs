using System;
using GraphQL.Types;
using NIT.HopZone.Web.Queries;

namespace NIT.HopZone.Web.Repository
{
    public class NTPSchema : Schema
    {
        public NTPSchema(Func<Type, GraphType> resolveType) : base(resolveType)
        {
            Query = (NTPQuery)resolveType(typeof(NTPQuery));
            Mutation = (NTPMutation)resolveType(typeof(NTPMutation));
        }
    }
}