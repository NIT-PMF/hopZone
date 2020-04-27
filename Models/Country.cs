using GraphQL.Types;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Models
{
    public class Country
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public int Id_country { get; set; }

        [BsonElement("CountryName")]
        [Required(ErrorMessage = "Country Name is required")]
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
