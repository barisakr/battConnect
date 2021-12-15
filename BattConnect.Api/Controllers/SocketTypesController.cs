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
    public class SocketTypesController : ControllerBase
    {
        private readonly ISocketTypeService _socketTypeService;
        private readonly IMapper _mapper;

        public SocketTypesController(ISocketTypeService socketTypeService,
        IMapper mapper)
        {
            _socketTypeService = socketTypeService;
            _mapper = mapper;
        }
        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<SocketTypeDTO>>> GetAllArtists()
        {
            var artists = await _socketTypeService.GetAllWithChargingCompany();
            var artistResources = _mapper.Map<IEnumerable<SocketType>, IEnumerable<SocketTypeDTO>>(artists);

            return Ok(artistResources);
        }
    }
}
