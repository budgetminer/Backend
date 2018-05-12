using BM2.Business.Base;
using BM2.DataAccess.Entities;
using DataAccess;

namespace BM2.Business.Writers {
    public class LevelsWriter : WriterBase<Level>, ILevelsWriter {

        public LevelsWriter(IUowProvider uowProvider) : base(uowProvider) {
        }
    }
}
