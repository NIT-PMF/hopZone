using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
