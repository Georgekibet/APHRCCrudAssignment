using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APHRC_Assigmnment.Shared.Models;

namespace APHRC.Data.Repositories
{
   public class InMemoryEmployeeRepository : IEmployeeRepository
   {
       private Dictionary<int, Employee> _mockDataBase;

       public InMemoryEmployeeRepository()
       {
           _mockDataBase ??= new Dictionary<int, Employee>();
        
       }

       public async Task<int> Save(Employee employee)
        {
            if (employee.Id == 0)
            {
                employee.Id = _mockDataBase.Count + 1;
                _mockDataBase.Add(employee.Id,employee);
            }

            if (_mockDataBase.ContainsKey(employee.Id))
            {
                _mockDataBase[employee.Id] = employee;
            }

            return employee.Id;
        }

       public async Task Delete(int id)
       {
           if (_mockDataBase.ContainsKey(id))
           {
               _mockDataBase.Remove(id);
           }
       }

       public async Task<IEnumerable<Employee>> GetAll(int skip = 0, int take = 1000)
        {
            return _mockDataBase.Values.Skip(skip).Take(take).ToList();
        }
    }
}
