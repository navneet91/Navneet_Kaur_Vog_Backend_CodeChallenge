using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.Entities.Models;
using VogCodeChallenge.Services.Abstracion;

namespace VogCodeChallenge.API.Controllers
{
    public class EmployeesController : Controller
    {
        private IEmployeeService _emp;
        public EmployeesController(IEmployeeService objEmp)
        {
            _emp = objEmp;

        }
        [HttpGet]
        public IList<Employee> Get()
        {
            return _emp.ListAll();
        }
        [HttpGet]
        [Route("api/employees/department/{departmentId}")]
        public IList<Employee> GetEmployeeForDepartment(int departmentId)
        {
            return _emp.ListAll();
        }
    }
}
