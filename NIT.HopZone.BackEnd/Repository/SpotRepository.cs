
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NIT.HopZone.Web.Entitites.Context;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Settings;

namespace NIT.HopZone.Web.Repository
{
    public class SpotRepository : ISpotRepository<Spot>
    {
        private readonly Context _context;

        public SpotRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<IEnumerable<Spot>> GetAll()
        {
            return await _context.Spot
                     .Find(_ => true)
                     .ToListAsync();
        }

        public async Task<List<Spot>> GetAllAsync()
        {
            return await _context.Spot
                       .Find(_ => true)
                       .ToListAsync();
        }

        public Task<Spot> GetItemAsync(string paramName, object paramValue)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Spot> insert(Spot admin)
        {
            await _context.Spot.InsertOneAsync(admin);

            return admin;

        }

    }
}


