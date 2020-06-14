using System;
using GraphQL;
using GraphQL.Types;
using NIT.HopZone.Web.Queries;

namespace NIT.HopZone.Web.Repository
{
    public class NTPSchema : Schema
    {
        public NTPSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<NTPQuery>();
            Mutation = resolver.Resolve<NTPMutation>();
        }
    }
}