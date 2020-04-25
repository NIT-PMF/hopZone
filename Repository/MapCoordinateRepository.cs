using HopZoneV2.Entitites.Context;
using HopZoneV2.Models;
using HopZoneV2.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Repository
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
