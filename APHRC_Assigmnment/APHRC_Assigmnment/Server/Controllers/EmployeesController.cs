using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APHRC.Data.Repositories;
using APHRC_Assigmnment.Shared.Models;
using CsvHelper;
using CsvHelper.Configuration;

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

        [HttpPost()]
        [Route("delete")]
        public async Task<ActionResult<int>> Delete([FromBody]Employee employee)
        {

             await _employeeRepository.Delete(employee.Id);
             return employee.Id;
        }
        [Route("employeereport")]
        public async Task<IActionResult> indiainfected()
        {
            var excel = await _employeeRepository.GetAll();
            var cc = new CsvConfiguration(new System.Globalization.CultureInfo("en-US"));
            var stream = new MemoryStream();
            using (var sw = new StreamWriter(stream: stream, encoding: new UTF8Encoding(true)))
            {
                using (var cw = new CsvWriter(sw, cc))
                {
                    cw.WriteRecords(excel);
                  //
                  // cw.WriteRecords
                }

            }
            string csvName = $"EmployeeReport-{DateTime.UtcNow.Ticks}.csv";
            return File(stream.ToArray(), "text/csv", csvName);
        }

    }
}
