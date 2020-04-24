using System;
using GraphQL.Types;
using HopZoneV2.Queries;

namespace HopZoneV2.Repository
{
    public class NTPSchema : Schema
    {
        public NTPSchema(Func<Type, GraphType> resolveType) : base(resolveType)
        {
            Query = (NTPQuery)resolveType(typeof(NTPQuery));
        }
    }
}