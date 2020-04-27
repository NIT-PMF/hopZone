using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NIT.HopZone.Web.Models
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
