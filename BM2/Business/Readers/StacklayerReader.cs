using BM2.Business.Base;
using BM2.Business.Readers.Definitions;
using BM2.DataAccess.BMEntities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Business.Readers
{
    public class StacklayerReader : ReaderBase<Stacklayer>, IStacklayerReader
    {
        public StacklayerReader(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
