using System.Collections.Generic;
using System.Threading.Tasks;
using NIT.HopZone.Web.Models;

namespace NIT.HopZone.Web.Repository
{
    public interface ICommentRepository<T>
    {
        Task<List<Comment>> GetAllAsync();
    }
}
