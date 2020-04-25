using HopZoneV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopZoneV2.Repository
{
    public interface IMapCoordinateRepository<T>
    {

        Task<List<MapCoordinate>> GetAllAsync();
    }
}
