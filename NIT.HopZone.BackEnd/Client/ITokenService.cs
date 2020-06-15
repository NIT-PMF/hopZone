using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NIT.HopZone.Web.NIT.HopZone.BackEnd.Client
{
    public interface ITokenService
    {
        Task<string> GetToken();
    }
}
