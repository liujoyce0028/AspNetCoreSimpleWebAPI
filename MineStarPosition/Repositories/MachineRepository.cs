using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineStarPosition.Cores;
using MineStarPosition.models;
using Microsoft.EntityFrameworkCore;

namespace MineStarPosition.Repositories
{
    public class MachineRepository : Repository<Machine>, IMachineRepository
    {

        private readonly MineWareContext _context;
        public MachineRepository(MineWareContext dbcontext) : base(dbcontext)
        {
            _context = dbcontext;
        }
        public async Task<IEnumerable<Machine>> GetCurrentListAsync()
        {
            Random rnd = new Random();

            //--

            //public int OriginatorId { get; set; }

            //public int Handle { get; set; }

            //public string MachineName { get; set; }
            //public string MachineCategory { get; set; }
            //public string Status { get; set; }

            //public string MachineMaker { get; set; }
            //public double MachineLength { get; set; }

            //public double MachineWidth { get; set; }

            //public double MachineHeight { get; set; }
            //--

            var list = await _context.MwMachines.Select(
                        a => new Machine
                        {
                            Id = a.MachineId,
                            OriginatorId = a.MachineId,
                            MachineName = a.MachineName,
                            MachineCategory = a.MachineTypeId.ToString(),
                            MachineHeight = 10,
                            MachineLength=10,
                            MachineMaker="Caterpillar",
                            Status="0",
                            MachineModel="D11T"
                        }
                        ).ToListAsync();


            return list;
        }


    }
}
