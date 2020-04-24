
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HopZoneV2.Repository
{
    public interface ITeamsCollectionRepository<T> : ICollectionRepository<T>
    {
        Task<IEnumerable<T>> GetItemsByTeamsAsync(string team2, string team1);
    }
}
