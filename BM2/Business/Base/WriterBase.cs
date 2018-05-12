using DataAccess;
using DataAccess.Entities;
using System;
using System.Threading.Tasks;

namespace BM2.Business.Base
{
    public abstract class WriterBase<T> : IWriterBase<T> where T : EntityBase, new()
    {
        private IUowProvider uowProvider;

        public WriterBase(IUowProvider uowProvider)
        {
            this.uowProvider = uowProvider ?? throw new ArgumentNullException(nameof(uowProvider));
        }

        public virtual async Task Add(T entity)
        {
            using (var uow = uowProvider.CreateUnitOfWork())
            {
                var repo = uow.GetRepository<T>();
                repo.Add(entity);
                await uow.SaveChangesAsync();
            }
        }

        public virtual async Task Update(T entity, int id)
        {
            using (var uow = uowProvider.CreateUnitOfWork())
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
        }

        public virtual async Task Delete(int id)
        {
            using (var uow = uowProvider.CreateUnitOfWork())
            {
                var repo = uow.GetRepository<T>();
                repo.Remove(id);

                await uow.SaveChangesAsync();
            }
        }
    }
}
