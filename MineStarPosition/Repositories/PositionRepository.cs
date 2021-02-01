using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MineStarPosition.Cores;
using MineStarPosition.models;

namespace MineStarPosition.Repositories
{
    public class PositionRepository : Repository<Position>, IPositionRepository
    {
        private readonly MineWareContext _context;
        public PositionRepository(MineWareContext dbcontext):base(dbcontext)
        {
            _context = dbcontext;
        }
        public async Task<IEnumerable<Position>> GetCurrentListAsync()
        {
            Random rnd = new Random();

            var list = await _context.DlCycleLogs.Where(c => c.StartTimeStamp >= DateTime.Today).Select(
                    a => new Position {
                        Id = a.UniqueId,
                        TimeStamp = a.StartTimeStamp,
                        OriginatorId = a.MachineId,
                        MachineName = "TestDozer",
                        Eastings = a.TubEastings + rnd.Next(-100, 100),
                        Northings = a.TubNorthings + rnd.Next(-100, 100),
                        Elevation = a.TubAltitude + rnd.Next(-100, 100),
                        Heading = a.DumpHeading,
                        Speed = a.ReturnTime
                    }
                    ).ToListAsync();
            

            return  list;
        }


    }
}
