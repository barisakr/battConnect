using BattConnect.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BattConnect.Core.Repositories
{
    public interface IChargingCompanyRepository : IRepository<ChargingCompany>
    {
        Task<IEnumerable<ChargingCompany>> GetAllWithSocketTypesAsync();
        Task<ChargingCompany> GetWithSocketTypesByIdAsync(int id);
    }
}
