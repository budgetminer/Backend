using AutoMapper;
using BM2.Models.ViewModels;
using BudgetMiner.Business.Base;
using BudgetMiner.Business.Readers.Definitions;
using BudgetMiner.DataAccess.BMEntities;
using DataAccess;
using DataAccess.Query;
using Microsoft.EntityFrameworkCore;
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

        /// <summary>
        /// Gets the partsgroup with a certain id and all of its children.
        /// </summary>
        /// <param name="id">The unique id of the partsgroup</param>
        /// <returns></returns>
        public async Task<PartsGroup> GetWithChildren(int id)
        {
            var result = new PartsGroup();
            using (var uow = _uowProvider.CreateUnitOfWork(false))
            {
                var includes = new Includes<PartsGroup>(query =>
                {
                    query = query.Include(x => x.Parts);
                    query = query.Include(x => x.Parts).ThenInclude(p => p.Costs);
                    query = query.Include(x => x.Parts).ThenInclude(p => p.PartType);
                    query = query.Include(x => x.Parts).ThenInclude(p => p.Individual);

                    return query;
                });

                var filter = new WhereFilter<PartsGroup>(x => x.Id == id);

                result = (await uow.GetRepository<PartsGroup>().QueryAsync(filter: filter.Expression, includes: includes.Expression)).FirstOrDefault();
            }

            await DecorateCosts(result.Parts);

            return result;
        }

        private async Task DecorateCosts(ICollection<Part> list)
        {
            foreach (var part in list)
            {
                foreach (var cost in part.Costs)
                {
                    cost.Costtype = await GetCostTypeForCostId(cost.CosttypeId);
                }
            }
        }

        private async Task<CostType> GetCostTypeForCostId(int costTypeId)
        {
            using (var uow = _uowProvider.CreateUnitOfWork())
            {
                var repo = uow.GetRepository<CostType>();

                var whereFilter = new WhereFilter<CostType>(ct => ct.Id == costTypeId);

                return (await repo.QueryAsync(whereFilter.Expression)).FirstOrDefault();
            }
        }
    }
}
