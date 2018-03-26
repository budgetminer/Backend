using BM2.Business.Exceptions;
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
    public class TeamsController : Controller
    {
        private ITeamReader reader;
        private ITeamWriter writer;

        public TeamsController(ITeamReader reader, ITeamWriter writer)
        {
            this.reader = reader ?? throw new NotImplementedException(nameof(reader));
            this.writer = writer ?? throw new NotImplementedException(nameof(writer));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await reader.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await reader.Get(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Team model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await writer.Add(model);
                    return Created("Get", new { id = model.Id });
                }
                catch (Exception ex)
                {
                    return BadRequest(new BusinessException("Er ging iets mis met het opslaan van de gegevens..", ex.StackTrace));
                }
            }
            else
            {
                return BadRequest(new ModelMappingException());
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody]Team model, int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    return await AddOrUpdateEntity(model, id);
                }
                catch (Exception ex)
                {
                    return BadRequest(new BusinessException("Er ging iets mee met het updaten van de gegevens..", ex.StackTrace));
                }
            }
            else
            {
                return BadRequest(new ModelMappingException());
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await writer.Delete(id);
            return NoContent();
        }

        private async Task<IActionResult> AddOrUpdateEntity(Team model, int id)
        {
            if (id == 0)
            {
                await writer.Add(model);
                return Created("Get", new { id = model.Id });
            }
            await writer.Update(model, id);
            return NoContent();
        }
    }
}
