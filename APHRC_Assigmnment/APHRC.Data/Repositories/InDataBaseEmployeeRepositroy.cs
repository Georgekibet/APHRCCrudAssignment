using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using APHRC_Assigmnment.Shared.Models;

namespace APHRC.Data.Repositories
{
   public class InDataBaseEmployeeRepositroy :IEmployeeRepository
    { 
        public async Task<int> Save(Employee employee)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAll(int skip = 0, int take = 1000)
        {
            throw new NotImplementedException();
        }
    }
}
