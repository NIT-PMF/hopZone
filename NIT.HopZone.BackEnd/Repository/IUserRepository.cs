using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HopZone.Models;

namespace NIT.HopZone.Web.NIT.HopZone.BackEnd.Repository
{
        public interface IUserRepository<T>
        {
        Task<IEnumerable<T>> GetAll();

        Task<T> insert(T user);
        Task<User> GetUserByUsername(string key, string username);
    }
}
