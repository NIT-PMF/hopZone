using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Models
{
    public class Post
    {

        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeCreated { get; set; }

        public string Description { get; set; }
        public int Like { get; set; }
        public string Id_user { get; set; }

        public string Spot_id { get; set; }
        public List<string> Id_routes { get; set; }
        public List<string> Id_comments { get; set; }
    }
}
