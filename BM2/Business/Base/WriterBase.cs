using DataAccess;
using DataAccess.Entities;
using System;
using System.Threading.Tasks;

namespace BM2.Business.Base
{
    public abstract class WriterBase<T> : IWriterBase<T> where T : EntityBase, new()
    {
        private IUnitOfWork uow;

        public WriterBase(IUnitOfWork uow)
        {
            this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
        }

        public virtual async Task Add(T entity)
        {
            var repo = uow.GetRepository<T>();
            repo.Add(entity);
            await uow.SaveChangesAsync();
        }

        public virtual async Task Update(T entity, int id)
        {
            var repo = uow.GetRepository<T>();
            if (repo.Get(id) != null)
            {
                repo.Update(entity);
            }
            else
            {
               await Add(entity);
            }
        }

        public virtual async Task Delete(int id)
        {
            var repo = uow.GetRepository<T>();
            repo.Remove(id);

            await uow.SaveChangesAsync();
        }
    }
}
