using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NIT.HopZone.Web.Models
{
    public class Gender
    {
        [BsonId]
        public ObjectId Id { get; set; }


        public enum NumGenderType
        {
            Male = 1,
            Female = 2,
            Other = 3,
        }

        [BsonRequired]
        // 1-Male 2-Female 3-Other
        public NumGenderType Type  { get; set; }

    }
}
