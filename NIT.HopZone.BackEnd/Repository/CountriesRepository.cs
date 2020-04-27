
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NIT.HopZone.Web.Entitites.Context;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Settings;

namespace NIT.HopZone.Web.Repository
{
    public class CountriesRepository : ICollectionRepository<Country>
    {
        private readonly Context _context;

        public CountriesRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<IEnumerable<Country>> GetItemsAsync()
        {
            try
            {
                return await _context.Countries
                    .Find(_ => true)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Country>> GetItemsAsync(string paramName, object paramValue)
        {
            try
            {

                return await _context.Countries
                    .Find(Builders<Country>.Filter.Eq(paramName, paramValue))
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Country> GetItemAsync(string paramName, object paramValue)
        {
            try
            {
                return await _context.Countries
                    .Find(Builders<Country>.Filter.Eq(paramName, paramValue))
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        Task<IEnumerable<Country>> ICollectionRepository<Country>.GetItemsAsync(string paramName, object paramValue)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<Country>> ICollectionRepository<Country>.GetItemsAsync()
        {
            throw new System.NotImplementedException();
        }

        Task<Country> ICollectionRepository<Country>.GetItemAsync(string paramName, object paramValue)
        {
            throw new System.NotImplementedException();
        }
    }
}
