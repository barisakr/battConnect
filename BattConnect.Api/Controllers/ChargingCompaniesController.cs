using AutoMapper;
using BattConnect.Api.DTO;
using BattConnect.Core.Models;
using BattConnect.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattConnect.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChargingCompaniesController : ControllerBase
    {
        private readonly IChargingCompanyService _chargingCompanyService;
        private readonly IMapper _mapper;

        public ChargingCompaniesController(IChargingCompanyService chargingCompanyService,
            IMapper mapper)
        {
            _chargingCompanyService = chargingCompanyService;
            _mapper = mapper;
        }
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<ChargingCompany>>> GetAll()
        {
            var chargingCompanies = await _chargingCompanyService.GetAllChargingCompanies(); 
            var chargingCompanyResources = _mapper.Map<IEnumerable<ChargingCompany>, IEnumerable<ChargingCompanyDTO>>(chargingCompanies);
            return Ok(chargingCompanyResources);
        }
    }
}
