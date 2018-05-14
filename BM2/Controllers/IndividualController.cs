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
    public class IndividualController : ControllerBase<Individual>
    {
        private IIndividualReader _reader;
        private IIndividualWriter _writer;

        public IndividualController(IIndividualReader reader, IIndividualWriter writer) : base(reader, writer)
        {
            _reader = reader ?? throw new ArgumentNullException(nameof(reader));
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        /// <summary>
        /// Get individuals for a specific team
        /// </summary>
        /// <param name="teamId">Gets all individuals of a team</param>
        /// <returns></returns>
        [HttpGet("/team/{teamId:int}")]
        public async Task<IActionResult> GetForTeam(int teamId)
        {
            var result = await _reader.GetForTeam(teamId);

            if (result != null)
            {
                return Ok(result);
            }
            else return NotFound(result);
        }
    }
}
