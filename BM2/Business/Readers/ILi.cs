using BM2.Business.Base;
using BM2.DataAccess.Entities;
using System.Collections.Generic;

namespace BM2.Business.Readers
{
    public interface ILiReader : IReaderBase<Li> {
        List<Li> GetByLiTypeCustomer(int custId, string licType);
    }
}
