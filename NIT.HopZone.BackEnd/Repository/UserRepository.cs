
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HopZone.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using NIT.HopZone.Web.Entitites.Context;
using NIT.HopZone.Web.NIT.HopZone.BackEnd.Repository;
using NIT.HopZone.Web.Settings;

namespace NIT.HopZone.Web.Repository
{
    public class UserRepository : IUserRepository<User>
    {
        private readonly Context _context;

        public UserRepository(IOptions<MongoSettings> settings)
        {
            _context = new Context(settings);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context
                .Users
                .Find(_ => true)
                .ToListAsync();
        }

        public async Task<User> insert(User user)
        {
            await _context.Users.InsertOneAsync(user);

            return user;

        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _context
                .Users
                .Find(_ => true)
                .ToListAsync();
        }

        public async Task<User> GetUserByUsername(string key, string name)
        {
            try
            {
                return await _context.Users
                    .Find(Builders<User>.Filter.Eq(key, name)).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
