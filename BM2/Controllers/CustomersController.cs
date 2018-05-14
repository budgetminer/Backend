using BM2.Business.Readers;
using BM2.Business.Writers;
using BM2.DataAccess.BMEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BM2.Controllers
{
    [Route("[controller]")]
    public class CustomersController : ControllerBase<Customer>
    {
        public CustomersController(ICustomerReader reader, ICustomerWriter writer) : base(reader, writer)
        {
        }

        [ProducesResponseType(typeof(Customer), 200)]
        public override Task<IActionResult> Get(int id)
        {
            return base.Get(id);
        }

        [ProducesResponseType(typeof(List<Customer>), 200)]
        public override Task<IActionResult> GetAll()
        {
            return base.GetAll();
        }
    }
}

