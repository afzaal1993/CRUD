using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Application.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Address = new AddressRepository(_context);
            City = new CityRepository(_context);
            Region = new RegionRepository(_context);
            Department = new DepartmentRepository(_context);
            Employee = new EmployeeRepository(_context);
        }
        public IAddressRepo Address { get; private set; }

        public ICityRepo City { get; private set; }

        public IRegionRepo Region { get; private set; }

        public IDepartmentRepo Department { get; private set; }

        public IEmployeeRepo Employee { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}