using BM2.Business.Base;
using BM2.DataAccess.BMEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BM2.Business.Readers.Definitions
{
    public interface IIndividualReader : IReaderBase<Individual>
    {
        Task<List<Individual>> GetForTeam(int teamId);
    }
}
