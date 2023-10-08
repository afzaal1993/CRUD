﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Region : BaseEntity
    {
        public string RegionName { get; set; }
        public List<City> Cities { get; set; }
    }
}
