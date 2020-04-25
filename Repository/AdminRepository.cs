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
    public class AdminRepository : ICollectionRepository<Admin>
    {
        private readonly Context _context;

        public AdminRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<IEnumerable<Admin>> GetAll()
        {
            return await _context
                .Admins
                .Include(x => x.FirstName)
                .Include(x => x.LastName)
                .Include(x => x.Username)
                .Include(x => x.Email)
                .Include(x => x.CreatedOn)
                .Include(x => x.UpdatedOn)
                .ToListAsync();
        }

        public Task<Admin> GetItemAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Admin>> GetItemsAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Admin>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
