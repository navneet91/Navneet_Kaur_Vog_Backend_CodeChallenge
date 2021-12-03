using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.DataManager.Abstraction;
using VogCodeChallenge.Entities.Models;

namespace VogCodeChallenge.DataManager.Implementation
{
   public  class EmployeeDataManager:IEmployeeDataManager
    {
      
       public IEnumerable<Employee> GetAllEmployee()
        {
            return EmployeeData.GetSampleEnumerableData();
        }
        public IList<Employee> ListAllEmployee()
        {
            return EmployeeData.GetSampleData();
        }
    }
}
