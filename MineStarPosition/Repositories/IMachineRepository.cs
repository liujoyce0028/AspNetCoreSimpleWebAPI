using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineStarPosition.Cores;

namespace MineStarPosition.Repositories
{
    public interface IMachineRepository: IRepository<Machine>
    {
        Task<IEnumerable<Machine>> GetCurrentListAsync();
    }
}
