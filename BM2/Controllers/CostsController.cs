using BudgetMiner.Business.Base;
using BudgetMiner.Business.Readers.Definitions;
using BudgetMiner.Business.Writers.Definitions;
using BudgetMiner.DataAccess.BMEntities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Controllers
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

        /// <summary>
        /// Gets the costs for a specific part and a specific cost type 
        /// </summary>
        /// <param name="partId"></param>
        /// <param name="costTypeId"></param>
        /// <returns></returns>
        [HttpGet("part/{partId:int}/costtype/{costTypeId:int}")]
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
