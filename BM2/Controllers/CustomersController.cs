using BM2.Business.Exceptions;
using BM2.Business.Readers;
using BM2.Business.Writers;
using BM2.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Threading.Tasks;

namespace BM2.Controllers
{
    [Route("[controller]")]
    public class CustomersController : Controller
    {
        private ICustomerReader reader;
        private ICustomerWriter writer;

        public CustomersController(ICustomerReader reader, ICustomerWriter writer)
        {
            this.reader = reader ?? throw new ArgumentNullException(nameof(reader));
            this.writer = writer ?? throw new ArgumentNullException(nameof(writer));
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
        public async Task<IActionResult> Post([FromBody]Customer model)
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

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Customer model, int id)
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


        private async Task<IActionResult> AddOrUpdateEntity(Customer model, int id)
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
