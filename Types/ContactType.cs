using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using HopZoneV2.Models;

namespace HopZoneV2.Types
{
    public class ContactType : ObjectGraphType<Contact>
    {
        public ContactType()
        {
            Field(_ => _.Id, type: typeof(StringGraphType));
            Field(_ => _.Username, type: typeof(StringGraphType));
            Field(_ => _.Subject, type: typeof(StringGraphType)).Description("Subject/Title of the Form");
            Field(_ => _.Body, type: typeof(StringGraphType)).Description("Main Topic/Subject of the Form");
            Field(_ => _.Email, type: typeof(StringGraphType));

        }
    }
}
