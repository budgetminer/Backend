using AutoMapper;
using BM2.Models.ViewModels;
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

        /// <summary>
        /// Get a specific partgroup with its part-children 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(typeof(PartsGroup), 200)]
        [HttpGet("{id:int}")]
        public override async Task<IActionResult> Get(int id)
        {
            var entity = await _reader.GetWithChildren(id);

            var result = Mapper.Map<PartsGroupModel>(entity);

            if (result != null)
            {
                return Ok(result);
            }
            else return NotFound(result);
        }
    }
}
