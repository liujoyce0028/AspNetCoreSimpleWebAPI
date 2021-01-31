using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineStarPosition.Cores;

namespace MineStarPosition.Repositories
{
   public interface IPositionRepository: IRepository<Position>
    {
        Task<IEnumerable<Position>> GetCurrentListAsync();
    }
}