using BM2.Business.Readers;
using BM2.Business.Writers;
using BM2.DataAccess.Entities;

namespace BM2.Controllers
{
    public class LevelsController : ControllerBase<Level>
    {
        public LevelsController(ILevelReader reader, ILevelWriter writer) : base(reader, writer)
        {
        }
    }
}
