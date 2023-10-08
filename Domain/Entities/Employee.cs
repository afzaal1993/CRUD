using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Navigation Proerties
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}