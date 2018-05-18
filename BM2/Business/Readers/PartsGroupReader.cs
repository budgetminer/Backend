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
    public class PartsGroupReader : ReaderBase<PartsGroup>, IPartsGroupReader
    {
        public PartsGroupReader(IUowProvider uowProvider) : base(uowProvider)
        {
        }

        public async Task<List<PartsGroup>> GetForComponent(int componentId)
        {
            return await GetForStackLayerAndComponent(componentId);
        }

        public async Task<List<PartsGroup>> GetForStackLayerAndComponent(int componentId, int stacklayerId = 0)
        {
            using (var uow = _uowProvider.CreateUnitOfWork())
            {
                var repo = uow.GetRepository<PartsGroup>();
                var whereFilter = new WhereFilter<PartsGroup>(null);
                whereFilter.AddExpression(pg => pg.ComponentId == componentId);
                if (stacklayerId != 0)
                {
                    whereFilter.AddExpression(pg => pg.StacklayerId == stacklayerId);
                }

                return (await repo.QueryAsync(whereFilter.Expression)).ToList();

            }
        }
    }
}
