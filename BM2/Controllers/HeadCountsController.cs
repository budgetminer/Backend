using BM2.Business.Base;
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
    public class HeadCountsController : ControllerBase<HeadCount>
    {
        public HeadCountsController(IHeadCountReader reader, IHeadCountWriter writer) : base(reader, writer)
        {
        }

        [ProducesResponseType(typeof(HeadCount), 200)]
        public override Task<IActionResult> Get(int id)
        {
            return base.Get(id);
        }

        [ProducesResponseType(typeof(List<HeadCount>), 200)]
        public override Task<IActionResult> GetAll()
        {
            return base.GetAll();
        }
    }
}
