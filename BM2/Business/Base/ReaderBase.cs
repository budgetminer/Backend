using DataAccess;
using DataAccess.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Base
{
    public abstract class ReaderBase<T> : IReaderBase<T> where T : EntityBase, new()
    {
        protected IUowProvider _uowProvider;

        public ReaderBase(IUowProvider uowProvider)
        {
            _uowProvider = uowProvider ?? throw new ArgumentNullException(nameof(uowProvider));
        }

        public virtual async Task<T> Get(int id)
        {
            using (var uow = _uowProvider.CreateUnitOfWork())
            {
                var repo = uow.GetRepository<T>();
                var result = await repo.GetAsync(id);
                return result;
            }
        }

        public virtual async Task<List<T>> GetAll()
        {
            using (var uow = _uowProvider.CreateUnitOfWork())
            {
                var repo = uow.GetRepository<T>();
                var result = await repo.GetAllAsync();
                return result.ToList();
            }
        }
    }
}
