using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using VogCodeChallenge.Entities.Models;
using VogCodeChallenge.Services.Abstracion;

namespace VogCodeChallenge.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        private IEmployeeService _emp;
        public EmployeesController(IEmployeeService objEmp)
        {
            _emp = objEmp;

        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_emp.ListAll());
            }
            catch(Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError,ex);
            }
        }
        [HttpGet]
        [Route("department/{departmentId}")]
        public IActionResult GetEmployeeForDepartment(Int16 departmentId)
        {
            try
            {

                return Ok(_emp.GetEmployeesForDepartment(departmentId));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
