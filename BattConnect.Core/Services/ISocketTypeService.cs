using BattConnect.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BattConnect.Core.Services
{
    public interface ISocketTypeService
    {
        Task<IEnumerable<SocketType>> GetAllWithChargingCompany();
        Task<SocketType> GetSocketTypeById(int id);
        Task<IEnumerable<SocketType>> GetSocketTypesByChargingCompanyId(int ChargingCompanyId);
      
    }
}
