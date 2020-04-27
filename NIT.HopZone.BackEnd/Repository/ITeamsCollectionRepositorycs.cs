
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Repository
{
    public interface ITeamsCollectionRepository<T> : ICollectionRepository<T>
    {
        Task<IEnumerable<T>> GetItemsByTeamsAsync(string team2, string team1);
    }
}
