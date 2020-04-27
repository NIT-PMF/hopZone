﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NIT.HopZone.Web.Entitites.Context;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace NIT.HopZone.Web.Repository
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
                .Find(_ => true)
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
