using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class RegionRepository : GenericRepository<Region>, IRegionRepo
    {
        public RegionRepository(AppDbContext context) : base(context)
        {

        }
    }
}