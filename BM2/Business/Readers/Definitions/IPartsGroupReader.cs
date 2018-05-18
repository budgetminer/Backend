using BM2.Models.ViewModels;
using BudgetMiner.Business.Base;
using BudgetMiner.DataAccess.BMEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Readers.Definitions
{
    public interface IPartsGroupReader : IReaderBase<PartsGroup>
    {
        Task<List<PartsGroup>> GetForStackLayerAndComponent(int componentId, int stacklayerId);
        Task<List<PartsGroup>> GetForComponent(int componentId);
        Task<PartsGroup> GetWithChildren(int id);
    }
}
