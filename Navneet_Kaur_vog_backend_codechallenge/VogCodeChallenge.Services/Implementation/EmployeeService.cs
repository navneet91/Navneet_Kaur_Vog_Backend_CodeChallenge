using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Services.Abstracion;
using VogCodeChallenge.Entities.Models;
using VogCodeChallenge.DataManager.Abstraction;
using System.Linq;

namespace VogCodeChallenge.Services.Implementation
{
    public class EmployeeService:IEmployeeService
    {
        private IEmployeeDataManager _emp;
      public  EmployeeService(IEmployeeDataManager objEmp)
        {
            _emp = objEmp;
                
        }
        public IEnumerable<Employee> GetAll()
        {
           return _emp.GetAllEmployee();
        }
       public IList<Employee> ListAll()
        {
           return _emp.ListAllEmployee();
        }
        public IList<Employee> GetEmployeesForDepartment(Int16 deptId)
        {
           return  _emp.ListAllEmployee().Where(x => x.deptId == deptId).ToList();
        }   
    }
}
