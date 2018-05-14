using BM2.Business.Base;
using BM2.Business.Readers.Definitions;
using BM2.DataAccess.BMEntities;
using DataAccess;
using DataAccess.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Readers
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

                whereFilter.AddExpression(i => i.TeamId == teamId));

                return (await repo.QueryAsync(whereFilter.Expression)).ToList(); 

            }
        }
    }
}
