using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Entities.Models;

namespace VogCodeChallenge.Services.Abstracion
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
    }
}
