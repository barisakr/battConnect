using BattConnect.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BattConnect.Core.Services
{
    public interface IChargingCompanyService
    {
        Task<IEnumerable<ChargingCompany>> GetAllChargingCompanies();
        Task<ChargingCompany> GetChargingCompanyById(int id);
        Task<ChargingCompany> CreateChargingCompany(ChargingCompany newChargingCompany);
        Task UpdateChargingCompany(ChargingCompany chargingCompanyToBeUpdated, ChargingCompany chargingCompany);
        Task DeleteChargingCompany(ChargingCompany chargingCompany);
    }
}
