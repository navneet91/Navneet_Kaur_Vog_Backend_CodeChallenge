using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Entities.Models;

namespace VogCodeChallenge.Services.Abstracion
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
        IList<Employee> GetEmployeesForDepartment(int deptId);
    }
}
