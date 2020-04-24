using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Models
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
