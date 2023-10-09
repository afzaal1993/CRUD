using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAddressRepo Address { get; }
        ICityRepo City { get; }
        IRegionRepo Region { get; }
        IDepartmentRepo Department { get; }
        IEmployeeRepo Employee { get; }

        public Task<int> Save();
    }
}