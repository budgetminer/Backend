using DataAccess;
using DataAccess.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Base
{
    public abstract class ReaderBase<T> : IReaderBase<T> where T : EntityBase, new()
    {
        private IUnitOfWork uow;

        public ReaderBase(IUnitOfWork uow)
        {
            this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
        }

        public virtual async Task<T> Get(int id)
        {
            var repo = uow.GetRepository<T>();
            var result = await repo.GetAsync(id);
            return result;
        }

        public virtual async Task<List<T>> GetAll()
        {
            var repo = uow.GetRepository<T>();
            var result = await repo.GetAllAsync();
            return result.ToList();
        }
    }
}
