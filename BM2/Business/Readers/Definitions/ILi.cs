using BM2.Business.Base;
using BM2.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BM2.Business.Readers
{
    public interface ILiReader : IReaderBase<License>
    {
        Task<List<License>> GetByLiTypeCustomer(int custId, string licType);
    }
}
