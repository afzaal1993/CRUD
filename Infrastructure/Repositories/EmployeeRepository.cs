using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepo
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public Employee CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            var result = _context.SaveChangesAsync();

            if (result.IsCompletedSuccessfully)
                return employee;
            else
                return null;
        }

        public void DeleteEmployee(int id)
        {
            var result = GetEmployeeById(id);
            _context.Employees.Remove(result);
            _context.SaveChangesAsync();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FindAsync(id).Result;
        }

        public async Task<IReadOnlyList<Employee>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChangesAsync();
            return employee;
        }
    }
}