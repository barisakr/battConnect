using BatConnect.Data;
using BattConnect.Core;
using BattConnect.Core.Repositories;
using BattConnect.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BattConnect.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BattConnectDbContext _context;
        private ChargingCompanyRepository _chargingCompanyRepository;
        private SocketTypeRepository _socketTypeRepository;

        public UnitOfWork(BattConnectDbContext context)
        {
            this._context = context;
        }

        public ISocketTypeRepository SocketTypes => _socketTypeRepository = _socketTypeRepository ?? new SocketTypeRepository(_context);

        public IChargingCompanyRepository ChargingCompanies => _chargingCompanyRepository = _chargingCompanyRepository ?? new ChargingCompanyRepository(_context);

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
