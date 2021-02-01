using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MineStarPosition.Repositories;
using MineStarPosition.Cores;

namespace MineStarPosition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public MachinesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/DlCycleLogs
        [HttpGet]
        public async Task<IEnumerable<Machine>> GetMachines()
        {
            // var test = _unitOfWork.Positions.GetCurrentListAsync();
            return await _unitOfWork.Machines.GetCurrentListAsync();
            // return await _context.DlCycleLogs.ToListAsync();
        }
    }
}
