using BM2.Business.Base;
using BM2.Business.Readers.Definitions;
using BM2.Business.Writers.Definitions;
using BM2.DataAccess.BMEntities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Controllers
{
    [Route("[controller]")]
    public class CostsController : ControllerBase<Costs>
    {
        private ICostsReader _reader;
        private ICostsWriter _writer;

        public CostsController(ICostsReader reader, ICostsWriter writer) : base(reader, writer)
        {
            _reader = reader ?? throw new ArgumentNullException(nameof(reader));
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        public async Task<IActionResult> GetForPartAndCostType(int partId, int costTypeId)
        {
            var result = await _reader.GetForPartAndCostType(partId, costTypeId);

            if (result != null)
            {
                return Ok(result);
            }
            else return NotFound(result);
        }
    }
}
