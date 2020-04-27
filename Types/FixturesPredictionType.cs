using GraphQL.Types;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.Web.Repository
{
    public class FixturesPredictionType : ObjectGraphType<FixturesPrediction>
    {
        public FixturesPredictionType()
        {
            Field(prediction => prediction.Rates, type: typeof(StringGraphType));
        }
    }
}