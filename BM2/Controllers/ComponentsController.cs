using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BM2.Business.Base;
using BM2.Business.Readers.Definitions;
using BM2.Business.Writers.Definitions;
using Microsoft.AspNetCore.Mvc;

namespace BM2.Controllers
{
    [Route("[controller]")]
    public class ComponentsController : ControllerBase<Component>
    {
        private IComponentReader _reader;
        private IComponentWriter _writer;

        public ComponentsController(IComponentReader reader, IComponentWriter writer) : base(reader, writer)
        {
            _reader = reader ?? throw new ArgumentNullException(nameof(reader));
            _writer = writer ?? throw new ArgumentNullException(nameof(writer));
        }

        [HttpGet("customer/{customerId:int}")]
        public Task<IActionResult> GetComponentsForCustomer(int customerId)
        {
            var result = _reader.GetComponentsForCustomer(customerId);

            throw new NotImplementedException();
        }
    }
}
