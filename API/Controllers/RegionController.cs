using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using AutoMapper;
using Domain.DTOs;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RegionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateRegion(CreateRegionDto createRegionDto)
        {
            //var region = _mapper.Map<Region>(createRegionDto);

            var region = new Region
            {
                RegionName = createRegionDto.RegionName,
                IsActive = true,
                CreatedDate = DateTime.Now,
                CreatedBy = createRegionDto.CreatedBy
            };

            _unitOfWork.Region.Add(region);
            var result = await _unitOfWork.Save();
            if (result > 0)
                return Ok("Region Created Successfully");
            else
                return BadRequest();
        }
    }
}