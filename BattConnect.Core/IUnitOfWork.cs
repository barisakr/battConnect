using BattConnect.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BattConnect.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IChargingCompanyRepository ChargingCompanies { get; }
        ISocketTypeRepository SocketTypes { get; } 
        Task<int> CommitAsync();
    }
}
