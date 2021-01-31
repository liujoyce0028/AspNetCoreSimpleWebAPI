using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MineStarPosition.Cores;
using MineStarPosition.Models;

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
            //            public int Id { get; set; }
            //public DateTime TimeStamp { get; set; }

            //public int? OriginatorId { get; set; }

            //public string MachineName { get; set; }

            //public double? Eastings { get; set; }

            //public double? Northings { get; set; }

            //public double? Elevation { get; set; }

            //public double? Heading { get; set; }

            //public double? Speed { get; set; }
            Random rnd = new Random();

            var list = await _context.DlCycleLogs.Where(c => c.StartTimeStamp >= DateTime.Today).Select(
                    a => new Position {
                        Id = a.UniqueId,
                        TimeStamp = a.StartTimeStamp,
                        OriginatorId = 999,
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
