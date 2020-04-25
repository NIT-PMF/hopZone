using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Models
{
    public class Post
    {

        [BsonId]
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public TimeSpan time_created { get; set; }

        public string description { get; set; }
        public int lajk { get; set; }
        public string Id_user { get; set; }

        public string spot_id { get; set; }
        public List<string> Id_routes { get; set; }
        public List<string> Id_comments { get; set; }
    }
}
