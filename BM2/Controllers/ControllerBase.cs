using BM2.Business.Base;
using BM2.Business.Exceptions;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Controllers
{
    public abstract class ControllerBase<T> : Controller where T : EntityBase
    {
        private IReaderBase<T> reader;
        private IWriterBase<T> writer;


        public ControllerBase(IReaderBase<T> reader, IWriterBase<T> writer)
        {
            this.reader = reader ?? throw new ArgumentNullException();
            this.writer = writer ?? throw new ArgumentNullException();
        }

        /// <summary>
        /// Retrieves all data of the given entity.
        /// </summary>
        /// <returns></returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(BusinessException), 400)]
        [HttpGet]
        public virtual async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await reader.GetAll());
            }
            catch (Exception ex)
            {
                return ErrorRetrieving(ex.StackTrace);
            }
        }

        /// <summary>
        /// Retrieves a specific entity with given id.
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns></returns>
        [ProducesResponseType(404)]
        [ProducesResponseType(typeof(BusinessException), 400)]
        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(int id)
        {
            try
            {
                var result = await reader.Get(id);
                if (result == null)
                {
                    return NotFound(new NotFoundException());
                }
                else
                {
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                return ErrorRetrieving(ex.StackTrace);
            }
        }

        /// <summary>
        /// Add a new entity to the database
        /// </summary>
        /// <param name="model">The according model</param>
        /// <returns></returns>
        [ProducesResponseType(201)]
        [ProducesResponseType(typeof(BusinessException), 400)]
        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody]T model)
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
                    return BadRequest(new BusinessException($"Error adding {nameof(T)}", ex.StackTrace));
                }
            }
            else
            {
                return BadRequest(new ModelMappingException());
            }
        }

        /// <summary>
        /// Update a certain entity given the updated model and the id.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(201)]
        [ProducesResponseType(204)]
        [ProducesResponseType(typeof(BusinessException), 400)]
        [HttpPut]
        
        public virtual async Task<IActionResult> Put([FromBody]T model, int id)
        {
            if (ModelState.IsValid)
            {
                var updaten = "updating";
                try
                {
                    if (id != 0)
                    {
                        updaten = "adding";
                        await writer.Update(model, id);
                        return NoContent();
                    }
                    else
                    {
                        await writer.Add(model);
                        return Created("Get", new { id = model.Id });
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(new BusinessException($"Error {updaten} {nameof(T)}", ex.StackTrace));
                }
            }
            else
            {
                return BadRequest(new ModelMappingException());
            }
        }

        /// <summary>
        /// Deletes the entity with given id.
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns></returns>
        [ProducesResponseType(204)]
        [ProducesResponseType(typeof(BusinessException), 400)]
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            try
            {
                await writer.Delete(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new BusinessException($"Error deleting {nameof(T)}", ex.StackTrace));
            }
        }



        private IActionResult ErrorRetrieving(string stacktrace)
        {
            return BadRequest(new BusinessException($"Error retrieving {nameof(T)}", stacktrace));
        }
    }
}
