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
    public class RoleRepository : ICollectionRepository<Role>
    {
        private readonly Context _context;

        public RoleRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<IEnumerable<Role>> GetAll()
        {
            return await _context
                .Roles
                .Find(_ => true)
                .ToListAsync();
        }

        public Task<Role> GetItemAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Role>> GetItemsAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Role>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
