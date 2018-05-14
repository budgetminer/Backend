using BM2.Business.Base;
using BM2.Business.Writers.Definitions;
using BM2.DataAccess.BMEntities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Writers
{
    public class CostsWriter : WriterBase<Costs>, ICostsWriter
    {
        public CostsWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
