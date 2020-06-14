using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NIT.HopZone.Web.Entitites.Context;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Settings;

namespace NIT.HopZone.Web.Repository
{
    public class CityRepository : ICollectionRepository<City>
    {
        private readonly Context _context;

        public CityRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<IEnumerable<City>> GetAll()
        {
            return await _context
                .Cities
                .Find(_ => true)
                .ToListAsync();
        }
        public async Task<City> insert(City admin)
        {
            await _context.Cities.InsertOneAsync(admin);

            return admin;

        }


        public Task<City> GetItemAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<City>> GetItemsAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<City>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
