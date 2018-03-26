using BM2.Business.Exceptions;
using BM2.Business.Readers;
using BM2.Business.Writers;
using BM2.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BM2.Controllers {
    [Route("[controller]")]
    public class LevelsController : Controller
    {
        ILevelsWriter writer;
        ILevelsReader reader;

        public LevelsController(ILevelsReader reader, ILevelsWriter writer) {
            this.writer = writer;
            this.reader = reader;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var result = await reader.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) {
            var result = await reader.Get(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Level level) {
            if (ModelState.IsValid) {
                try {
                    await writer.Add(level);
                    return Created("Get", new { id = level.Id });
                }
                catch (Exception ex) {
                    return BadRequest(new BusinessException("Fout bij toevoegen", ex.StackTrace));
                }
            }
            else {
                return BadRequest(new ModelMappingException());
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody]Level level, int id) {
            if (ModelState.IsValid) {
                try {
                    if (id == 0) {
                        await writer.Add(level);
                        return Created("Get", new { id = level.Id });
                    }
                    else {
                        await writer.Update(level, id);
                        return NoContent();
                    }
                }
                catch (Exception ex) {
                    return BadRequest(new BusinessException("Fout bij toevoegen", ex.StackTrace));
                }
            }
            else {
                return BadRequest(new ModelMappingException());
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete (int id) {
            try {
                await writer.Delete(id);
                return NoContent();
            }
            catch (Exception ex) {
                return BadRequest(new BusinessException("Fout bij verwijderen", ex.StackTrace));
            }
        }
    }
}
