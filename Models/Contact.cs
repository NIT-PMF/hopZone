using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NIT.HopZone.Web.Models
{
    public class Contact
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonRequired]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [BsonRequired]
        public string Subject { get; set; } = string.Empty;

        [BsonRequired]
        public string Body { get; set; } = string.Empty;

        [EmailAddress]
        [BsonRequired]
        public string Email { get; set; }
    }
}
