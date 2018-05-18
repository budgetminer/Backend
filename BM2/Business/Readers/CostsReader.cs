using BudgetMiner.Business.Base;
using BudgetMiner.Business.Readers.Definitions;
using BudgetMiner.DataAccess.BMEntities;
using DataAccess;
using DataAccess.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Readers
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
