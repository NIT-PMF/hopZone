using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.NIT.HopZone.BackEnd.Repository.Interface
{
    public interface IContactRepository<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> add(T contactForm);
    }
}
