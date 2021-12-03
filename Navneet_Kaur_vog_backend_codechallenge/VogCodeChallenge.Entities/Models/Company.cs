using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VogCodeChallenge.Entities.Models
{
    public class Company
    {
        [Key]
        public Int16 CompanyId { get; set; }
        public string CompanyName { get; set; }
        public List<Department> Departments { get; set; }
    }
}
