using BudgetMiner.Business.Base;
using BudgetMiner.DataAccess.BMEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Readers.Definitions
{
    public interface IIndividualReader : IReaderBase<Individual>
    {
        Task<List<Individual>> GetForTeam(int teamId);
    }
}
