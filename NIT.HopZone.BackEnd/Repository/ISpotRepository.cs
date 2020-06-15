using System.Collections.Generic;
using System.Threading.Tasks;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.Web.Repository
{
    public interface ISpotRepository<T>
    {

        Task<IEnumerable<T>> GetAll();
        Task<T> GetItemAsync(string paramName, object paramValue);

        Task<T> insert(T role);
    }
}
