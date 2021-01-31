using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineStarPosition.Models;
using MineStarPosition.Cores;

namespace MineStarPosition.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MineWareContext _context;
        private PositionRepository _positionRepository;

        public UnitOfWork(MineWareContext context) {
            _context = context;
        }

        public IPositionRepository Positions => _positionRepository = _positionRepository ?? new PositionRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();

        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
