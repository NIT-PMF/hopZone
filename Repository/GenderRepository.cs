using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HopZoneV2.Entitites.Context;
using HopZoneV2.Models;
using HopZoneV2.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HopZoneV2.Repository
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
                .Include(x => x.Type)
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
