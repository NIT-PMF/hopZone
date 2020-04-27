using NIT.HopZone.Web.Entitites.Context;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Repository
{
    public class SeasonsRepository : ICollectionRepository<Season>
    {
        private readonly Context _context;

        public SeasonsRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<IEnumerable<Season>> GetItemsAsync()
        {
            try
            {
                return await _context.Seasons
                    .Find(_ => true)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public async Task<IEnumerable<Season>> GetItemsAsync(string paramName, object paramValue)
        {
            try
            {
                return await _context.Seasons
                    .Find(Builders<Season>.Filter.Eq(paramName, paramValue))
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public async Task<Season> GetItemAsync(string paramName, object paramValue)
        {
            try
            {
                return await _context.Seasons
                    .Find(Builders<Season>.Filter.Eq(paramName, paramValue))
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        Task<IEnumerable<Season>> ICollectionRepository<Season>.GetItemsAsync(string paramName, object paramValue)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<Season>> ICollectionRepository<Season>.GetItemsAsync()
        {
            throw new System.NotImplementedException();
        }

        Task<Season> ICollectionRepository<Season>.GetItemAsync(string paramName, object paramValue)
        {
            throw new System.NotImplementedException();
        }
    }
}
