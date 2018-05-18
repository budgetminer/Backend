using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetMiner.Business.Base;
using BudgetMiner.Business.Readers.Definitions;
using BudgetMiner.DataAccess.BMEntities;
using DataAccess;
using DataAccess.Query;

namespace BudgetMiner.Business.Readers
{
    public class ComponentReader : ReaderBase<Component>, IComponentReader
    {
        public ComponentReader(IUowProvider uowProvider) : base(uowProvider)
        {
        }

        public async Task<List<Component>> GetComponentsForCustomer(int customerId)
        {
            using (var uow = _uowProvider.CreateUnitOfWork())
            {
                var repo = uow.GetRepository<Component>();

                var filter = new WhereFilter<Component>(null);
                filter.AddExpression(c => c.CustomerId == customerId);

                return (await repo.QueryAsync(filter.Expression)).ToList();
            }
        }
    }
}
