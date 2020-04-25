using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using HopZoneV2.Models;

namespace HopZoneV2.Types
{
    public class NumGenderType : EnumerationGraphType<Gender> { }
    public class GenderType : ObjectGraphType<Gender>
    {
        public GenderType()
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field<NumGenderType>(nameof(Gender.Type));
        }
    }
}
