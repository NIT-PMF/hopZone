using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NIT.HopZone.Web.Models
{
    public class Spot
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Description { get; set; }

        public string ImageURL { get; set; }
        public string Id_map_coordinate { get; set; }
        public string Id_city { get; set; }
    }
}
