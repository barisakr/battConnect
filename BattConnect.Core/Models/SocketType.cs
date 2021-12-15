using System;
using System.Collections.Generic;
using System.Text;

namespace BattConnect.Core.Models
{
    public class SocketType
    {
        public int Id { get; set; } 
        public string Code { get; set; } 
        public string Name { get; set; } 
        public int ChargingCompanyId { get; set; }
        public ChargingCompany ChargingCompany { get; set; }
    }
}
