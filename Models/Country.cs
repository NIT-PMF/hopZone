using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Models
{
    public class Country
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int Id_country { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
