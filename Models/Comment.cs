using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Models
{
    public class Comment
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string  comment { get; set; }
        public TimeSpan time_written { get; set; }
        public int laik { get; set; }
        public string Id_user { get; set; }
        public string Id_post { get; set; }
    }
}
