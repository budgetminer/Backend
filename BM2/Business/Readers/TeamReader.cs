using BudgetMiner.Business.Base;
using BudgetMiner.DataAccess.BMEntities;
using DataAccess;

namespace BudgetMiner.Business.Readers
{
    public class TeamReader : ReaderBase<Team>, ITeamReader
    {
        public TeamReader(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
