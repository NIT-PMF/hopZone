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
    public class GenderRepository : ICollectionRepository<Gender>
    {
        private readonly Context _context;

        public GenderRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<IEnumerable<Gender>> GetAll()
        {
            return await _context
                .Genders
                .Find(_ => true)
                .ToListAsync();
        }

        public Task<Gender> GetItemAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Gender>> GetItemsAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Gender>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
