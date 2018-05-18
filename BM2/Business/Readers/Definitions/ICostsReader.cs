using BudgetMiner.Business.Base;
using BudgetMiner.DataAccess.BMEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Readers.Definitions
{
    public interface ICostsReader : IReaderBase<Costs>
    {
        Task<List<Costs>> GetForPartAndCostType(int partId, int costTypeId);
    }
}
