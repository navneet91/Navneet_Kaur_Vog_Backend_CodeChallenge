using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VogCodeChallenge.DataManager.Abstraction;
using VogCodeChallenge.Entities.Models;

namespace VogCodeChallenge.DataManager.Implementation
{
   public  class EmployeeDataManager: BaseRepo<Employee>, IEmployeeDataManager
    {
        //db object
        private EmployeeInfoContext _dbContext;
       public EmployeeDataManager(EmployeeInfoContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return GetAll();
            
        }
        public IList<Employee> ListAllEmployee()
        {
           return GetAll().ToList();
        }
    }
}
