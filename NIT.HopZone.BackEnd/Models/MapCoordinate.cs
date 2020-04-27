using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

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
