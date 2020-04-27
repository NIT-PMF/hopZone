using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NIT.HopZone.Web.Entitites.Context;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Settings;

namespace NIT.HopZone.Web.Repository
{
    public class MapCoordinateRepository : IMapCoordinateRepository<MapCoordinate>
    {
        private readonly Context _context;

        public MapCoordinateRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<List<MapCoordinate>> GetAllAsync()
        {
            return await _context.MapCoordinate
                      .Find(_ => true)
                      .ToListAsync();
        }
    }
}
