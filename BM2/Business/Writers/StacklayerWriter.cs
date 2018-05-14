using BM2.Business.Base;
using BM2.Business.Writers.Definitions;
using BM2.DataAccess.BMEntities;
using DataAccess;

namespace BM2.Business.Writers
{
    public class StacklayerWriter : WriterBase<Stacklayer>, IStacklayerWriter
    {
        public StacklayerWriter(IUowProvider uowProvider) : base(uowProvider)
        {

        }
    }
}
