using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver.Core.WireProtocol.Messages;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.Web.Repository
{
    public interface ISpotRepository<T>
    {

        Task<IEnumerable<T>> GetAll();
        Task<T> GetItemAsync(string paramName, object paramValue);

        Task<IEnumerable<Spot>> getSpots(string username, string key);
        Task<T> insert(T role);
    }
}
