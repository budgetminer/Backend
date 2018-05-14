using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM2.Business.Base;
using BM2.Business.Readers.Definitions;
using BM2.Business.Writers.Definitions;
using BM2.DataAccess.BMEntities;
using Microsoft.AspNetCore.Mvc;

namespace BM2.Controllers
{
    [Route("[controller]")]
    public class PartsController : ControllerBase<Part>
    {
        private IPartsReader _reader;

        public PartsController(IPartsReader reader, IPartsWriter writer) : base(reader, writer)
        {
            _reader = reader ?? throw new ArgumentNullException(nameof(reader));
        }
        /// <summary>
        /// Gets all the parts for a certain partType AND a partgroup
        /// </summary>
        /// <param name="partGroupId">The partGroup id</param>
        /// <param name="partTypeId">The partType id</param>
        /// <returns></returns>
        [ProducesResponseType(typeof(List<Part>), 200)]
        [HttpGet("partgroup/{partGroupId:int}/parttype/{partTypeId:int}")]
        public async Task<IActionResult> GetPartForPartGroupAndPartType(int partGroupId, int partTypeId)
        {
            var result = await _reader.GetPartForPartGroupAndPartType(partGroupId, partTypeId);
            if (result == null)
            {
                return NotFound(new NotFoundObjectResult(result));
            }
            return Ok(result);
        }
    }
}
