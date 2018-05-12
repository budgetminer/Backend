using DataAccess;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BM2.DataAccess.Entities;
using System.Linq;
using BM2.Business.Base;

namespace BM2.Business.Readers
{
    public class CotyReader : ReaderBase<CostType>, ICotyReader
    {
        private IUowProvider uowProvider;

        public CotyReader(IUowProvider uowProvider ) : base(uowProvider)
        {
            this.uowProvider = uowProvider ?? throw new ArgumentNullException(nameof(uowProvider));
        }
    }
}
