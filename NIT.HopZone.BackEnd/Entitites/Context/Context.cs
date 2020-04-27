using HopZone.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Settings;

namespace NIT.HopZone.Web.Entitites.Context
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

        public IMongoCollection<Spot> Spot
        {
            get
            {
                return _database.GetCollection<Spot>("spots");
            }
        }
        public IMongoCollection<Route> Route
        {
            get
            {
                return _database.GetCollection<Route>("routes");
            }
        }
        public IMongoCollection<Comment> Comment
        {
            get
            {
                return _database.GetCollection<Comment>("comment");
            }
        }
        public IMongoCollection<MapCoordinate> MapCoordinate
        {
            get
            {
                return _database.GetCollection<MapCoordinate>("mapcoordinates");
            }
        }
        public IMongoCollection<Post> Post
        {
            get
            {
                return _database.GetCollection<Post>("posts");
            }
        }

        public IMongoCollection<Admin> Admins
        {
            get
            {
                return _database.GetCollection<Admin>("admins");
            }
        }

        public IMongoCollection<Gender> Genders
        {
            get
            {
                return _database.GetCollection<Gender>("genders");
            }
        }
        public IMongoCollection<Role> Roles
        {
            get
            {
                return _database.GetCollection<Role>("roles");
            }
        }
        public IMongoCollection<City> Cities
        {
            get
            {
                return _database.GetCollection<City>("cities");
            }
        }

        public IMongoCollection<User> Users
        {
            get
            {
                return _database.GetCollection<User>("users");
            }
        }

        public IMongoCollection<Contact> Contacts
        {
            get
            {
                return _database.GetCollection<Contact>("contacts");
            }
        }

        public object Owners { get; internal set; }
    }

}