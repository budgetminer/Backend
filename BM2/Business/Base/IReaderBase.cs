using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Base
{
    public interface IReaderBase<T> where T : EntityBase
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
    }
}
