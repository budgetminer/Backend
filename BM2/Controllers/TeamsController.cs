using BM2.Business.Exceptions;
using BM2.Business.Readers;
using BM2.Business.Writers;
using BM2.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Controllers
{
    [Route("[controller]")]
    public class TeamsController : ControllerBase<Team>
    {
        private ITeamReader reader;
        private ITeamWriter writer;

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
