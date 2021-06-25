using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APHRC.Data.Repositories;
using APHRC_Assigmnment.Shared.Models;

namespace APHRC_Assigmnment.Server.Controllers
{
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _employeeRepository.GetAll();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody]Employee employee)
        {

            return await _employeeRepository.Save(employee);
        }


    }
}
