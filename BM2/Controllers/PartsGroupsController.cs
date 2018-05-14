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
    public class PartsGroupsController : ControllerBase<PartsGroup>
    {
        private IPartsGroupReader _reader;
        private IPartsGroupWriter _writer;

        public PartsGroupsController(IPartsGroupReader reader, IPartsGroupWriter writer) : base(reader, writer)
        {
            _reader = reader ?? throw new ArgumentNullException(nameof(reader));
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        /// <summary>
        /// Gets a list of all the partsgroups from a certain stacklayer/component.
        /// </summary>
        /// <param name="stacklayerId">The id of the stacklayer</param>
        /// <param name="componentId">The id of the component</param>
        /// <returns></returns>
        [ProducesResponseType(typeof(List<PartsGroup>), 200)]
        [HttpGet("stacklayer/{stacklayerId:int}/componentId/{componentId:int}")]
        public async Task<IActionResult> GetForStackLayerAndComponent(int componentId, int stacklayerId)
        {
            var result = await _reader.GetForStackLayerAndComponent(componentId, stacklayerId);

            if (result != null)
            {
                return Ok(result);
            }
            else return NotFound(result);
        }

        /// <summary>
        /// Gets a list of all partsgroup with a certain componentId
        /// </summary>
        /// <param name="componentId">The id of the component</param>
        /// <returns></returns>
        [ProducesResponseType(typeof(List<PartsGroup>), 200)]
        [HttpGet("component/{componentId:int}")]
        public async Task<IActionResult> GetForComponent(int componentId)
        {
            var result = await _reader.GetForComponent(componentId);

            if (result != null)
            {
                return Ok(result);
            }
            else return NotFound(result);
        }
    }
}
