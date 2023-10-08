using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class City : BaseEntity
    {
        public string CityName { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}
