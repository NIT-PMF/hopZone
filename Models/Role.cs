using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NIT.HopZone.Web.Models
{
    public class Role
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonRequired]
        public int Authority { get; set; } = 0;
    }
}
