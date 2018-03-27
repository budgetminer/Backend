using BM2.Business.Base;
using BM2.DataAccess.Entities;
using DataAccess;

namespace BM2.Business.Readers
{
    public class LevelReader : ReaderBase<Level>, ILevelReader
    {
        public LevelReader(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
