
using HopZoneV2.Entitites.Context;
using HopZoneV2.Models;
using HopZoneV2.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HopZoneV2.Repository
{
    public class SpotRepository : ISpotRepository<Spot>
    {
        private readonly Context _context;

        public SpotRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<List<Spot>> GetAllAsync()
        {
            return await _context.Spot
                       .Find(_ => true)
                       .ToListAsync();
        }

    }
}


