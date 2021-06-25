using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APHRC_Assigmnment.Shared.Models;

namespace APHRC_Assigmnment.Server.Controllers
{
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
           var employees= new List<Employee>();

           var employee1= new Employee()
           {
               FullName = "Name 1",
               JobTittle = "CEO",
               Contact = "+254710908934",
               NextOfKin = new List<EmployeeNextOfKin>(),
               Dependants = new List<EmployeeDependant>(),
               Id = 3
               
           };
           employees.Add(employee1);
           var employee2= new Employee()
           {
               FullName = "Name 2",
               JobTittle = "Director general",
               Contact = "+254710908834",
               NextOfKin = new List<EmployeeNextOfKin>(),
               Dependants = new List<EmployeeDependant>(),
               Id = 2
               
           };
           employees.Add(employee2);
            return employees;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Employee student)
        {
           // context.Students.Add(student);
           // await context.SaveChangesAsync();
            return student.Id;
        }


    }
}
