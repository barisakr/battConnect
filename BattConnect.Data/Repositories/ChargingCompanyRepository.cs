using Microsoft.EntityFrameworkCore;
using BattConnect.Core.Models;
using BattConnect.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BatConnect.Data;

namespace BattConnect.Data.Repositories
{
    public class ChargingCompanyRepository : Repository<ChargingCompany>, IChargingCompanyRepository
    {
        public ChargingCompanyRepository(BattConnectDbContext context)
            : base(context)
        { }

        public async Task<IEnumerable<ChargingCompany>> GetAllWithSocketTypesAsync()
        {
            return await BattConnectDbContext.ChargingCompanies
                 .Include(a => a.SocketTypes)
                 .ToListAsync();
        }

        public Task<ChargingCompany> GetWithSocketTypesByIdAsync(int id)
        {
            return BattConnectDbContext.ChargingCompanies
               .Include(a => a.SocketTypes)
               .SingleOrDefaultAsync(a => a.Id == id);
        }
        private BattConnectDbContext BattConnectDbContext
        {
            get { return Context as BattConnectDbContext; }
        }
    }
}
