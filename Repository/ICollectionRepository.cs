using HopZoneV2.Models;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HopZoneV2.Repository
{
    public interface ICollectionRepository<T>
    {
        Task<IEnumerable<T>> GetItemsAsync(string paramName, object paramValue);
        Task<IEnumerable<T>> GetItemsAsync();
        Task<T> GetItemAsync(string paramName, object paramValue);
    }
}
