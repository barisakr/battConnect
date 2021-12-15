using BattConnect.Core;
using BattConnect.Core.Models;
using BattConnect.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BattConnect.Services
{
    public class SocketTypeService : ISocketTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SocketTypeService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<SocketType> CreateSocketType(SocketType newSocketType)
        {
            await _unitOfWork.SocketTypes.AddAsync(newSocketType);
            await _unitOfWork.CommitAsync();
            return newSocketType;
        }

        public async Task DeleteMusic(SocketType socketType)
        {
            _unitOfWork.SocketTypes.Remove(socketType);
            await _unitOfWork.CommitAsync();
        }

        public Task<IEnumerable<SocketType>> GetAllWithChargingCompany()
        {
            throw new NotImplementedException();
        }

        public Task<SocketType> GetSocketTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SocketType>> GetSocketTypesByChargingCompanyId(int ChargingCompanyId)
        {
            throw new NotImplementedException();
        }
    }
}
