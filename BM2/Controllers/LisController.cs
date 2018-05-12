using BM2.Business.Readers;
using BM2.Business.Writers;
using BM2.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BM2.Controllers {
    [Route("[controller]")]
    public class LisController : ControllerBase<Li> {
        private ILiReader _reader;

        public LisController(ILiReader reader, ILiWriter writer) : base(reader, writer) {
            _reader = reader;
        }

        [ProducesResponseType(typeof(Li), 200)]
        public override Task<IActionResult> Get(int id) {
            return base.Get(id);
        }

        [ProducesResponseType(typeof(List<Li>), 200)]
        public override Task<IActionResult> GetAll() {
            return base.GetAll();
        }

        public Task<IActionResult> GetByLiTypeCustomer(int custId, string licType) {
            var result = _reader.GetByLiTypeCustomer(custId, licType);
            return result;
        }
    }
}

