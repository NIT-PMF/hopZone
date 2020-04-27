using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NIT.HopZone.Web.Models
{
    public class Fixture : SerializationFixture
    {

        [BsonId]
        public ObjectId Id { get; set; }

    }
}
