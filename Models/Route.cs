using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Models
{
    public class Route
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }

        public DateTime TimePosted { get; set; }

        public string  Description { get; set; }
        public string ImageURL { get; set; }

        public List<string> Id_spots { get; set; }
        public  int Id_city { get; set; }
    }
}
