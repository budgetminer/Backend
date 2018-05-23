using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetMiner.Business.Base;
using BudgetMiner.Business.Readers.Definitions;
using BudgetMiner.Business.Writers.Definitions;
using BudgetMiner.DataAccess.BMEntities;
using Microsoft.AspNetCore.Mvc;

namespace BudgetMiner.Controllers
{
    [Route("[controller]")]
    public class ComponentsController : ControllerBase<Component>
    {
        private IComponentReader _reader;
        private IComponentWriter _writer;

        public ComponentsController(IComponentReader reader, IComponentWriter writer) : base(reader, writer)
        {
            _reader = reader ?? throw new ArgumentNullException(nameof(reader));
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        /// <summary>
        /// Returns the components for a specific customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        [HttpGet("customer/{customerId:int}")]
        public async Task<IActionResult> GetComponentsForCustomer(int customerId)
        {
            var result = await _reader.GetComponentsForCustomer(customerId);

            if (result != null) {
                return Ok(result);
            }
            else return NotFound(result);
        }
    }
}
