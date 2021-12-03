using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VogCodeChallenge.DataManager.Abstraction;
using VogCodeChallenge.Entities.Models;

namespace VogCodeChallenge.DataManager.Implementation
{
    public class BaseRepo<T>: IBaseRepo<T> where T:class
    {
        private EmployeeInfoContext _dbContext;
        private DbSet<T> dbSet;
        private List<DbSet<T>> lstdbSet;
        public BaseRepo(EmployeeInfoContext context)
        {
            _dbContext = context;
            dbSet = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            IEnumerable<T> returnvalues;
            returnvalues = this.dbSet.AsEnumerable<T>();
            return returnvalues;
        }
      

    }
}
