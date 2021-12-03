using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.Entities.Models
{
   public class EmployeeInfoContext:DbContext
    {
        public EmployeeInfoContext()
        {
        }
        public EmployeeInfoContext(DbContextOptions<EmployeeInfoContext> options)
           : base(options)
        {
        }
        public virtual DbSet<Employee> EmployeeDetails { get; set; }
        public virtual DbSet<Department> DepartmentDetails { get; set; }

    }
}
