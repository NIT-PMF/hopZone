using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using NIT.HopZone.Web.Models;

namespace HopZone.Models
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonRequired]
        public string FirstName { get; set; }

        [BsonRequired]
        public string LastName { get; set; }

        [BsonRequired]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        public string Description { get; set; }

        [EmailAddress]
        [BsonRequired]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [BsonRequired]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [BsonDateTimeOptions]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [BsonRequired]
        public string City { get; set; }

        [BsonRequired]
        public string Gender { get; set; }

        [BsonRequired]
        public int Role { get; set; } = 0;

        [BsonRequired]
        public bool Active { get; set; } = true;

        //public List<Post> Posts {get; set;}

    }
}
