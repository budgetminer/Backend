using BudgetMiner.Business.Readers;
using BudgetMiner.Business.Writers;
using BudgetMiner.DataAccess.BMEntities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetMiner.Controllers {
    [Route("[controller]")]
    public class TeamsController : ControllerBase<Team>
    {

        public TeamsController(ITeamReader reader, ITeamWriter writer) : base(reader, writer)
        {
        }

        [ProducesResponseType(typeof(Team), 200)]
        public override Task<IActionResult> Get(int id)
        {
            return base.Get(id);
        }

        [ProducesResponseType(typeof(List<Team>), 200)]
        public override Task<IActionResult> GetAll()
        {
            return base.GetAll();
        }
    }
}
