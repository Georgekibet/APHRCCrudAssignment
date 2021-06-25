using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using APHRC_Assigmnment.Shared.Models;

namespace APHRC.Data.Repositories
{
  public  interface IEmployeeRepository
  {
      public Task<int> Save(Employee employee);
      public Task Delete(int id);

      public Task<IEnumerable<Employee>> GetAll(int skip=0,int take=1000);
  }
}
