using NIT.HopZone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.Repository
{
    public interface ICommentRepository<T>
    {
        Task<List<Comment>> GetAllAsync();
    }
}
