using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HopZoneV2.Models
{
    public class City
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonRequired]
        [BsonElement("CityName")]
        [Required(ErrorMessage = "City Name is required")]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Code { get; set; }

        [BsonRequired]
        public Country Country { get; set; }
    }
}
