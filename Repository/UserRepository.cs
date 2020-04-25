using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HopZone.Models;
using HopZoneV2.Entitites.Context;
using HopZoneV2.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HopZoneV2.Repository
{
    public class UserRepository : ICollectionRepository<User>
    {
        private readonly Context _context;

        public UserRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context
                .Users
                .Include(_ => true)
                .ToListAsync();
        }
        public Task<User> GetItemAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetItemsAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
