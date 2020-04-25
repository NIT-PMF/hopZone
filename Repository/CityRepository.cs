using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HopZoneV2.Entitites.Context;
using HopZoneV2.Models;
using HopZoneV2.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace HopZoneV2.Repository
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
