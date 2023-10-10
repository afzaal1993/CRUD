using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.DTOs;
using Domain.Entities;

namespace API.AutoMapperProfile
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Region, CreateRegionDto>();
        }
    }
}