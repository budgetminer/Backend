using BM2.Business.Base;
using BM2.DataAccess.Entities;
using DataAccess;

namespace BM2.Business.Writers
{
    public class HeadCountWriter : WriterBase<HeadCount>, IHeadCountWriter
    {
        public HeadCountWriter(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
