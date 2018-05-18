using BudgetMiner.Business.Base;
using BudgetMiner.DataAccess.BMEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Readers.Definitions
{
    public interface IComponentReader : IReaderBase<Component>
    {
        Task<List<Component>> GetComponentsForCustomer(int customerId);

    }
}
