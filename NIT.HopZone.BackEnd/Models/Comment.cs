using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NIT.HopZone.Web.Models
{
    public class Comment
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Body { get; set; }
        public DateTime TimeWritten { get; set; }
        public int Like { get; set; }
        public string Id_user { get; set; }
        public string Id_post { get; set; }
    }
}
