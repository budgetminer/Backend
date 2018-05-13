using BM2.Business.Base;
using BM2.DataAccess.Entities;
using DataAccess;

namespace BM2.Business.Writers
{
    public class CostTypeWriter : WriterBase<CostType>, ICotyWriter
    {

        public CostTypeWriter(IUowProvider uowProvider) : base(uowProvider)
        {
        }
    }
}
