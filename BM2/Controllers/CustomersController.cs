using BudgetMiner.Business.Readers;
using BudgetMiner.Business.Writers;
using BudgetMiner.DataAccess.BMEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetMiner.Controllers
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

