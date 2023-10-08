using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Domain.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepo _employeeRepo;
        public EmployeesController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ApiResponse<List<Employee>>), 200)]
        public async Task<IActionResult> GetEmployees()
        {
            var result = await _employeeRepo.GetEmployees();
            return Ok(ApiResponse<List<Employee>>.Success(result));
        }

        [HttpGet("{id}")]
        public Employee GetEmployeeById(int id)
        {
            return _employeeRepo.GetEmployeeById(id);
        }

        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateEmployee(Employee employee)
        {
            var result = _employeeRepo.CreateEmployee(employee);
            return CreatedAtAction("GetEmployeeById", new { id = employee.Id }, employee);
        }

        [HttpPut]
        [Route("Update")]
        public ActionResult UpdateEmployee(Employee employee)
        {
            var result = _employeeRepo.UpdateEmployee(employee);
            return Ok(result);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            _employeeRepo.DeleteEmployee(id);
            return Ok("Employee Deleted Successfully.");
        }
    }
}