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
    public class RouteRepository : IRouteRepository<Route>
    {
        private readonly Context _context;

        public RouteRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<List<Route>> GetAllAsync()
        {
            return await _context.Route
                       .Find(_ => true)
                       .ToListAsync();
        }
    }
}

