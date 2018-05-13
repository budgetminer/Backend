﻿using BM2.Business.Readers;
using BM2.Business.Writers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BM2.Controllers {
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
