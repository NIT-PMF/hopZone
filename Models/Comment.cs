using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Models
{
    public class Comment
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string  Body { get; set; }
        public DateTime TimeWritten { get; set; }
        public int Like { get; set; }
        public string Id_user { get; set; }
        public string Id_post { get; set; }
    }
}
