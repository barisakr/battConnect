
using BatConnect.Data;
using BattConnect.Core.Models;
using BattConnect.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BattConnect.Data.Repositories
{
    public class SocketTypeRepository : Repository<SocketType>, ISocketTypeRepository
    {
        public SocketTypeRepository(BattConnectDbContext context)
           : base(context)
        { }
   
      

       
        private BattConnectDbContext BattConnectDbContext
        {
            get { return Context as BattConnectDbContext; }
        }

        public async Task<IEnumerable<SocketType>> GetAllWithChargingCompanyAsync()
        {
            return await BattConnectDbContext.SocketTypes
                .Include(x => x.ChargingCompany)
                .ToListAsync();
        }

        public async Task<IEnumerable<SocketType>> GetAllByChargingCompanyIdAsync(int chargingCompanyId)
        {
            return await BattConnectDbContext.SocketTypes
                 .Include(m => m.ChargingCompany)
                 .Where(m => m.ChargingCompanyId == chargingCompanyId)
                 .ToListAsync();
        }

        public Task<SocketType> GetWithChargingCompanyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
