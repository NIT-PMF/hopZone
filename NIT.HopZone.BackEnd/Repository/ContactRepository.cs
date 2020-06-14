using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NIT.HopZone.Web.Entitites.Context;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.NIT.HopZone.BackEnd.Repository.Interface;
using NIT.HopZone.Web.Settings;

namespace NIT.HopZone.Web.Repository
{
    public class ContactRepository : IContactRepository<Contact>
    {
        private readonly Context _context;

        public ContactRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<Contact> add(Contact contact)
        {
            await _context.Contacts.InsertOneAsync(contact);

            return contact;

        }

        public async Task<IEnumerable<Contact>> GetAll()
        {
            return await _context
                .Contacts
                .Find(_ => true)
                .ToListAsync();
        }
    }
}