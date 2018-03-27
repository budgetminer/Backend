using System.Collections.Generic;
using System.Threading.Tasks;
using BM2.Business.Readers;
using BM2.Business.Writers;
using BM2.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BM2.Controllers
{
    [Route("[controller]")]
    public class LevelsController : ControllerBase<Level>
    {
        public LevelsController(ILevelReader reader, ILevelWriter writer) : base(reader, writer)
        {
        }

        [ProducesResponseType(typeof(Level), 200)]
        public override Task<IActionResult> Get(int id)
        {
            return base.Get(id);
        }

        [ProducesResponseType(typeof(List<Level>), 200)]
        public override Task<IActionResult> GetAll()
        {
            return base.GetAll();
        }
    }
}
