using DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BM2.DataAccess.Entities;
using System.Linq;
using BM2.Business.Base;

namespace BM2.Business.Readers
{
    public class CotyReader : ReaderBase<Coty>, ICotyReader
    {
        private IUnitOfWork uow;

        public CotyReader(IUnitOfWork uow ) : base(uow)
        {
            this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
        }
    }
}
