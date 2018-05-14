using BM2.Business.Base;
using BM2.DataAccess.BMEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Readers.Definitions
{
    public interface IPartsGroupReader : IReaderBase<PartsGroup>
    {
        Task<List<PartsGroup>> GetForStackLayerAndComponent(int componentId, int stacklayerId);
        Task<List<PartsGroup>> GetForComponent(int componentId);
    }
}
