using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineStarPosition.Cores;
using MineStarPosition.Models;
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


            var list = await _context.MwMachines.Select(
                        a => new Machine
                        {
                            Id = a.MachineId,
                            OriginatorId = a.MachineId,
                            MachineName = a.MachineName,
                            MachineCategory = a.MachineTypeId.ToString(),
                            MachineHeight = 10,
                            MachineLength=10,
                            MachineMake="Caterpillar",
                            Status="0",
                            MachineModel="D11T"
                        }
                        ).ToListAsync();


            return list;
        }


    }
}
