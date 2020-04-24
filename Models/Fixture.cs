﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Models
{
    public class Fixture : SerializationFixture
    {

        [BsonId]
        public ObjectId Id { get; set; }

    }
}