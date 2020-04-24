using HopZoneV2.Models;
using HopZoneV2.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Entitites.Context
{
    public class Context
    {

        private readonly IMongoDatabase _database = null;

        public Context(IOptions<MongoSettings> settings)
        {
            try
            {
                var client = new MongoClient("mongodb+srv://NIT:12345nit@cluster0-vd97p.mongodb.net/test?retryWrites=true&w=majority");

                _database = client.GetDatabase("hopzone");

            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
        public IMongoCollection<Fixture> Fixtures
        {
            get
            {
                return _database.GetCollection<Fixture>("fixtures");
            }
        }

        public IMongoCollection<Country> Countries
        {
            get
            {
                return _database.GetCollection<Country>("countries");
            }
        }

        public IMongoCollection<Season> Seasons
        {
            get
            {
                return _database.GetCollection<Season>("seasons");
            }
        }

        public object Owners { get; internal set; }
    }

}