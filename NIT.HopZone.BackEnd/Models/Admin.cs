using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NIT.HopZone.Web.Models
{
    public class Admin
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonRequired]
        public string FirstName { get; set; }

        [BsonRequired]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [BsonRequired]
        public string Username { get; set; }

        [EmailAddress]
        [BsonRequired]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [BsonRequired]
        [MinLength(5)]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [BsonDateTimeOptions]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [BsonDateTimeOptions]
        public DateTime UpdatedOn { get; set; } = DateTime.Now;
    }
}
