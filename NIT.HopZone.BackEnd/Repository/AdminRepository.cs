using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NIT.HopZone.Web.Entitites.Context;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Settings;

namespace NIT.HopZone.Web.Repository
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
                .Find(_ => true)
                .ToListAsync();
        }
        public Task<Admin> GetItemAsync(string paramName, object paramValue)
        {
            throw new NotImplementedException();
        }

        //dodo
        public async Task<Admin> insert(Admin admin)
        {
            await _context.Admins.InsertOneAsync(admin);

            return admin;
           
        } 

        public async Task<IEnumerable<Admin>> GetItemsAsync(string paramName, object paramValue)
        {
            try
            {
                return await _context.Admins
                    .Find(Builders<Admin>.Filter.Eq(paramName, paramValue))
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Admin>> GetItemsAsync()
        {
            try
            {
                return await _context
                    .Admins
                    .Find(_ => true)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object insert(Route route)
        {
            throw new NotImplementedException();
        }
    }
}
