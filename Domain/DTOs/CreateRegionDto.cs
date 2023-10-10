using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class CreateRegionDto
    {
        [Required]
        public string RegionName { get; set; }
        public string CreatedBy { get; set; }
    }
}