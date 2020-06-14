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
        public async Task<Role> insert(Role admin)
        {
            await _context.Roles.InsertOneAsync(admin);

            return admin;

        }



        public Task<IEnumerable<Role>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
