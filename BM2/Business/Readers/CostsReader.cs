using BM2.Business.Base;
using BM2.Business.Readers.Definitions;
using BM2.DataAccess.BMEntities;
using DataAccess;
using DataAccess.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Readers
{
    public class CostsReader : ReaderBase<Costs>, ICostsReader
    {
        public CostsReader(IUowProvider uowProvider) : base(uowProvider)
        {
        }

        public async Task<List<Costs>> GetForPartAndCostType(int partId, int costTypeId)
        {
            using (var uow = _uowProvider.CreateUnitOfWork())
            {
                var repo = uow.GetRepository<Costs>();

                var whereFilter = new WhereFilter<Costs>(null);
                whereFilter.AddExpression(c => c.CosttypeId == costTypeId && c.PartId == partId);

                return (await repo.QueryAsync(whereFilter.Expression)).ToList();
            }
        }
    }
}
