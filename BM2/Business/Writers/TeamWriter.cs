using BudgetMiner.Business.Base;
using BudgetMiner.DataAccess.BMEntities;
using DataAccess;

namespace BudgetMiner.Business.Writers
{
    public class TeamWriter : WriterBase<Team>, ITeamWriter
    {
        public TeamWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
