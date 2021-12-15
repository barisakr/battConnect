using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BattConnect.Core.Models
{
    public class ChargingCompany
    {
        public ChargingCompany()
        {
            SocketTypes = new Collection<SocketType>();
        }
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public ICollection<SocketType> SocketTypes { get; set; }


    }
}
