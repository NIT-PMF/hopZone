using GraphQL.Types;
using HopZoneV2.Models;

namespace HopZoneV2.Repository
{
    public class FixturesPredictionType : ObjectGraphType<FixturesPrediction>
    {
        public FixturesPredictionType()
        {
            Field(prediction => prediction.Rates, type: typeof(StringGraphType));
        }
    }
}