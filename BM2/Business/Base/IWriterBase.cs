﻿using DataAccess.Entities;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Base
{
    public interface IWriterBase<T> where T : EntityBase
    {
        Task Add(T entity);
        Task Update(T entity, int id);
        Task Delete(int id);
    }
}
