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
    public class ContactRepository : ICollectionRepository<Contact>
    {
        private readonly Context _context;

        public ContactRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<IEnumerable<Contact>> GetAll()
        {
            return await _context
                .Contacts
                .Include(x => x.Username)
                .Include(x => x.Subject)
                .Include(x => x.Body)
                .Include(x => x.Email)
                .ToListAsync();
        }

        public Task<Contact> GetItemAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetItemsAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
