using HopZoneV2.Models;
using HopZoneV2.Settings;
using Microsoft.EntityFrameworkCore;
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
                var client = new MongoClient(settings.Value.ConnectionString);

                _database = client.GetDatabase(settings.Value.Database);

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