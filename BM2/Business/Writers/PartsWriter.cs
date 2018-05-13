using BM2.Business.Base;
using BM2.Business.Writers.Definitions;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Writers
{
    public class PartsWriter : WriterBase<Part>, IPartsWriter
    {
        public PartsWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
