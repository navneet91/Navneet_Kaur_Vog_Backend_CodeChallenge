using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.DataManager.Abstraction
{
    public interface IBaseRepo<T> where T : class
    {
         IEnumerable<T> GetAll();
        
    }
}
