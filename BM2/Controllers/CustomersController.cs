using BM2.DataAccess;
using BM2.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Controllers {
    [Route("[controller]")]
    public class CustomersController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAll() {
            using (var db = new EntityContext()) {
                return Ok(await db.Customers.ToListAsync());
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            using (var db = new EntityContext()) {
                return Ok(db.Customers.Where(x => x.id == id).FirstOrDefault());
            }
        }
        
        [HttpPost]
        public async Task<IActionResult> Post(Customer model) {
            try {
                if (model != null) {
                    using (var db = new EntityContext()) {
                        await db.Customers.AddAsync(model);
                        await db.SaveChangesAsync();
                    }
                    return Ok("Aanmaken customer OK");
                }
                return BadRequest("Model klopt niet");
            }
            catch (Exception ) {
                return BadRequest("Aanmaken customer mislukt");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Customer model, int id) {
            try {
                if (model != null) {
                    using (var db = new EntityContext()) {
                        var oudeEntity = await db.Customers.FindAsync(id);
                        if (oudeEntity != null) {
                            db.Customers.Update(model);
                        }
                        else {
                            await db.Customers.AddAsync(model);
                        }
                        await db.SaveChangesAsync();
                    }
                    return Ok("Upgedatet");
                }
                return BadRequest("Model klopt niet");
            }
            catch (Exception) {
                return BadRequest("Updaten mislukt");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete (int id) {
            try {
                using (var db = new EntityContext()) {
                    db.Customers.Remove(await db.Customers.Where(x => x.id == id).FirstOrDefaultAsync());
                    await db.SaveChangesAsync();
                }
                return Ok("Deleted");
            }
            catch (Exception) {
                return BadRequest("delete mislukt");
            }
        }

    }
}
