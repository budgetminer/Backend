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
    public class LicenseReader : ReaderBase<License>, ILiReader
    {
        private IUowProvider uowProvider;

        public LicenseReader(IUowProvider uowProvider ) : base(uowProvider)
        {
            this.uowProvider = uowProvider ?? throw new ArgumentNullException(nameof(uowProvider));
        }

        public async Task<List<License>> GetByLiTypeCustomer(int custId, string licType)
        {
            using (var uow = uowProvider.CreateUnitOfWork())
            {
                var repo = uow.GetRepository<License>();

                var filter = new WhereFilter<License>(null);
                var includes = new Includes<License>(query =>
                {
                    query.Include(x => x.LicenseType);
                    query.Include(x => x.Customer);
                    return query;
                });
                filter.AddExpression(l => l.Customer.Id == custId && l.LicenseType.Abbreviation == licType);

                return (await repo.QueryAsync(filter.Expression, includes: includes.Expression)).ToList();
            }
        }
    }
}
