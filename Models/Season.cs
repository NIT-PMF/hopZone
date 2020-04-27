using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Models
{
    public class Season
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int Id_country { get; set; }
        public int Id_league { get; set; }
        public int Id_season { get; set; }
        public string Name { get; set; }
        public string Years { get; set; }
    }
}
