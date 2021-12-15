using AutoMapper;
using BattConnect.Api.DTO;
using BattConnect.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattConnect.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<ChargingCompany, ChargingCompanyDTO>().ReverseMap();
            CreateMap<SocketType, SocketTypeDTO>().ReverseMap();
              
        }
    }
}
