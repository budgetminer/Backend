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
    public class PartsReader : ReaderBase<Part>, IPartsReader
    {
        public PartsReader(IUowProvider uowProvider) : base(uowProvider)
        {
        }

        public async Task<List<Part>> GetPartForPartGroupAndPartType(int partGroupId, int partTypeId)
        {
            using (var uow = _uowProvider.CreateUnitOfWork())
            {
                var repo = uow.GetRepository<Part>();

                var filter = new WhereFilter<Part>(null);
                filter.AddExpression(f => f.PartsGroupId == partGroupId && f.PartTypeId == partTypeId);

                return (await repo.QueryAsync(filter.Expression)).ToList();
            }
        }
    }
}
