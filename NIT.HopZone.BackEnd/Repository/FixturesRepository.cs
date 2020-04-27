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
    public class FixturesRepository : ITeamsCollectionRepository<Fixture>
    {
        private readonly Context _context;

        public FixturesRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<IEnumerable<Fixture>> GetItemsAsync()
        {
            try
            {
                return await _context.Fixtures
                    .Find(_ => true)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Fixture>> GetItemsByTeamsAsync(string team1Name, string team2Name)
        {
            try
            {
                var filterStr = "\"" + team1Name + "\"\"" + team2Name + "\"";

                return await _context.Fixtures
                    .Find(Builders<Fixture>.Filter.Text(filterStr))
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Fixture>> GetItemsAsync(string paramName, object paramValue)
        {
            try
            {
                return await _context.Fixtures
                    .Find(Builders<Fixture>.Filter.Eq(paramName, paramValue))
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Fixture> GetItemAsync(string paramName, object paramValue)
        {
            try
            {
                return await _context.Fixtures
                    .Find(Builders<Fixture>.Filter.Eq(paramName, paramValue))
                    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
