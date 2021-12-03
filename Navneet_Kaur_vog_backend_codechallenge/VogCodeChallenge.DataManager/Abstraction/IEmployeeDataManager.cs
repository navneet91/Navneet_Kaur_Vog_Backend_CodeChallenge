using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Entities.Models;

namespace VogCodeChallenge.DataManager.Abstraction
{
   public  interface IEmployeeDataManager
    {
        IEnumerable<Employee> GetAllEmployee();
        IList<Employee> ListAllEmployee();
    }
}
