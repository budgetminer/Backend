﻿using BM2.Business.Readers;
using BM2.Business.Writers;
using BM2.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BM2.Controllers
{
    [Route("[controller]")]
    public class CotysController : ControllerBase<Coty>
    {
        public CotysController(ICotyReader reader, ICotyWriter writer) : base(reader, writer)
        {
        }

        [ProducesResponseType(typeof(Coty), 200)]
        public override Task<IActionResult> Get(int id)
        {
            return base.Get(id);
        }

        [ProducesResponseType(typeof(List<Coty>), 200)]
        public override Task<IActionResult> GetAll()
        {
            return base.GetAll();
        }
    }
}
