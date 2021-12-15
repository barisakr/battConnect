using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattConnect.Api.DTO
{
    public class SocketTypeDTO
    {
        public int Id { get; set; }
        public string Code { get; set; } 
        public ChargingCompanyDTO ChargingCompany { get; set; }
    }
}
