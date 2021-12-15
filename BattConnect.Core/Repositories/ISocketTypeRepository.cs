using BattConnect.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BattConnect.Core.Repositories
{
    public interface ISocketTypeRepository : IRepository<SocketType>
    { 
        Task<IEnumerable<SocketType>> GetAllWithChargingCompanyAsync();
        Task<SocketType> GetWithChargingCompanyByIdAsync(int id);
        Task<IEnumerable<SocketType>> GetAllByChargingCompanyIdAsync(int chargingCompanyId);
    }
}
