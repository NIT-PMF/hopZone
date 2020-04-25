using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Models
{
    public class Route
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string name { get; set; }

        public TimeSpan time_posted { get; set; }

        public string  description { get; set; }
        public string image_url { get; set; }

        public List<string> Id_spots { get; set; }
        public  int Id_city { get; set; }
    }
}
