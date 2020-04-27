using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Models
{
    public class MapCoordinate
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
