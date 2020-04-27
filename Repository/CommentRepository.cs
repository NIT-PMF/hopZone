using NIT.HopZone.Web.Entitites.Context;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.Settings;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Repository
{
    public class CommentRepository : ICommentRepository<Comment>
    {
        private readonly Context _context;

        public CommentRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }


        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comment
                .Find(_ => true)
                .ToListAsync();
        }
    }
}
