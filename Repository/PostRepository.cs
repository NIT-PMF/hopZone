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
    public class PostRepository : IPostRepository<Post>
    {
        private readonly Context _context;

        public PostRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<List<Post>> GetAllAsync()
        {
            return await _context.Post
                       .Find(_ => true)
                       .ToListAsync();
        }
    }
}

