using BudgetMiner.Business.Base;
using BudgetMiner.DataAccess.BMEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Readers.Definitions
{
    public interface IPartsReader : IReaderBase<Part>
    {
        Task<List<Part>> GetPartForPartGroupAndPartType(int partGroupId, int partTypeId);
    }
}
