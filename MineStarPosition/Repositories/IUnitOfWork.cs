using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MineStarPosition.Repositories
{
  public  interface IUnitOfWork:IDisposable
    {
        IPositionRepository Positions { get; }
    }
}
