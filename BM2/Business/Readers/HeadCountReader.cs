using BM2.Business.Base;
using BM2.DataAccess.Entities;
using DataAccess;

namespace BM2.Business.Readers
{
    public class HeadCountReader : ReaderBase<HeadCount>, IHeadCountReader
    {
        public HeadCountReader(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
