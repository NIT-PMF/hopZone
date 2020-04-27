using System.Collections;

namespace NIT.HopZone.Web.Models
{
    public class FixturesPrediction
    {
        public FixturesPrediction(Hashtable rates)
        {
            Rates = rates;
        }

        public Hashtable Rates { get; }
    }
}
