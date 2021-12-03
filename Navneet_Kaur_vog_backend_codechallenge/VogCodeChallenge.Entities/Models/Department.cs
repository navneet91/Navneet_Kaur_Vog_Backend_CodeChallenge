using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VogCodeChallenge.Entities.Models
{
    public class Department
    {
        [Key]
        public Int16 DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptAddress { get; set; }
        public List<Employee> Employees { get; set; }

    }
}
