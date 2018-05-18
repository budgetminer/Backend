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
    public class IndividualReader : ReaderBase<Individual>, IIndividualReader
    {
        public IndividualReader(IUowProvider uowProvider) : base(uowProvider)
        {
        }

        public async Task<List<Individual>> GetForTeam(int teamId)
        {
            using (var uow = _uowProvider.CreateUnitOfWork())
            {
                var repo = uow.GetRepository<Individual>();
                var whereFilter = new WhereFilter<Individual>(null);

                whereFilter.AddExpression(i => i.TeamId == teamId);

                return (await repo.QueryAsync(whereFilter.Expression)).ToList(); 
            }
        }
    }
}
