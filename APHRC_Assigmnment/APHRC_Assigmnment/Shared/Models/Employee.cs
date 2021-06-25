using System;
using System.Collections.Generic;

namespace APHRC_Assigmnment.Shared.Models
{
    public class Employee
    {
        public  Employee()
        {
          NextOfKin =new List<EmployeeNextOfKin>();
          Dependants= new List<EmployeeDependant>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string JobTittle { get; set; }
        public List<EmployeeNextOfKin> NextOfKin { get; set; }
        public List<EmployeeDependant> Dependants { get; set; }
        public string Contact { get; set; }

    }
}
