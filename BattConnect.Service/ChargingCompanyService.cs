using BattConnect.Core;
using BattConnect.Core.Models;
using BattConnect.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BattConnect.Services
{
    public class ChargingCompanyService : IChargingCompanyService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChargingCompanyService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }


        public async Task<ChargingCompany> CreateChargingCompany(ChargingCompany newChargingCompany)
        {
            await _unitOfWork.ChargingCompanies
                  .AddAsync(newChargingCompany);

            return newChargingCompany; 
        }

        public async Task DeleteChargingCompany(ChargingCompany chargingCompany)
        {
            _unitOfWork.ChargingCompanies.Remove(chargingCompany); 
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<ChargingCompany>> GetAllChargingCompanies()
        {
            return await _unitOfWork.ChargingCompanies.GetAllAsync();
        }

        public async Task<ChargingCompany> GetChargingCompanyById(int id)
        {
            return await _unitOfWork.ChargingCompanies.GetByIdAsync(id);
        }

        public async Task UpdateChargingCompany(ChargingCompany chargingCompanyToBeUpdated, ChargingCompany chargingCompany)
        {
            chargingCompanyToBeUpdated.Name = chargingCompany.Name; 
            await _unitOfWork.CommitAsync();
        }
    }
}
