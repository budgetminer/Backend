using DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BM2.DataAccess.Entities;
using System.Linq;
using BM2.Business.Base;

namespace BM2.Business.Readers
{
    public class LiReader : ReaderBase<Li>, ILiReader
    {
        private IUnitOfWork uow;

        public LiReader(IUnitOfWork uow ) : base(uow)
        {
            this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
        }

        public List<Li> GetByLiTypeCustomer(int custId, string licType) {
            var result = uow.GetRepository<Li>();

            result.QueryAsync(l => )
        }
    }
}
