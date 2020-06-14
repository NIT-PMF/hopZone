using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HopZone.Models;

namespace NIT.HopZone.Web.NIT.HopZone.BackEnd.Repository
{
        public interface IUserRepository<T>
        {
        Task<IEnumerable<T>> GetItemsAsync(string paramName, object paramValue);
        Task<IEnumerable<T>> GetItemsAsync();

        Task<IEnumerable<T>> GetAll();
        Task<T> GetItemAsync(string paramName, object paramValue);

        Task<T> insert(T user);
    }
}
