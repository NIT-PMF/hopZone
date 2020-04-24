﻿using System.Collections.Generic;
using System.IO;
using HopZoneV2.Models;
using MongoDB.Bson;
using Newtonsoft.Json;



namespace HopZoneV2.Settings
{
    public class JsonAdapter
    {
        private readonly string _filePath;
        
        public JsonAdapter(string dir = null)
        {
            if (dir == null)
            {
                _filePath = Directory.GetCurrentDirectory() + "\\Json\\";
            }
        }

        
        public string GetPreparedForInsert(string fileName)
        {
            using (var file = File.OpenText(_filePath + fileName))
            {
                var serializer = new JsonSerializer();
                var fixtures = (IEnumerable<SerializationFixture>) serializer.Deserialize(
                    file, typeof(IEnumerable<SerializationFixture>)
                );

                return fixtures.ToJson();
            }
        }
    }
}