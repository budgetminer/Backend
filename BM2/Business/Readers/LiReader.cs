using DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BM2.DataAccess.Entities;
using System.Linq;
using BM2.Business.Base;
using DataAccess.Query;
using Microsoft.EntityFrameworkCore;

namespace BM2.Business.Readers
{
    public class LiReader : ReaderBase<License>, ILiReader
    {
        private IUowProvider uowProvider;

        public LiReader(IUowProvider uowProvider ) : base(uowProvider)
        {
            this.uowProvider = uowProvider ?? throw new ArgumentNullException(nameof(uowProvider));
        }

        public async Task<List<License>> GetByLiTypeCustomer(int custId, string licType)
        {
            using (var uow = uowProvider.CreateUnitOfWork())
            {
                var repo = uow.GetRepository<License>();

                var filter = new Filter<License>(null);
                var includes = new Includes<License>(query =>
                {
                    query.Include(x => x.lity);
                    query.Include(x => x.cu);
                    return query;
                });
                filter.AddExpression(l => l.cu.Id == custId && l.lity.abbrev == licType);

                return (await repo.QueryAsync(filter.Expression, includes: includes.Expression)).ToList();
            }
        }
    }
}
