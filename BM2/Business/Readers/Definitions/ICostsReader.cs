using BM2.Business.Base;
using BM2.DataAccess.BMEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Readers.Definitions
{
    public interface ICostsReader : IReaderBase<Costs>
    {
        Task<List<Costs>> GetForPartAndCostType(int partId, int costTypeId);
    }
}
