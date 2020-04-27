using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Models
{
    public class Fixture : SerializationFixture
    {

        [BsonId]
        public ObjectId Id { get; set; }

    }
}
