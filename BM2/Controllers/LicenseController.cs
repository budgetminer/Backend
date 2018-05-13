using BM2.Business.Readers;
using BM2.Business.Writers;
using BM2.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BM2.Controllers
{
    [Route("[controller]")]
    public class LicenseController : ControllerBase<License>
    {
        private ILicenseReader _reader;

        public LicenseController(ILicenseReader reader, ILicenseWriter writer) : base(reader, writer)
        {
            _reader = reader;
        }

        [ProducesResponseType(typeof(License), 200)]
        public override Task<IActionResult> Get(int id)
        {
            return base.Get(id);
        }

        [ProducesResponseType(typeof(List<License>), 200)]
        public override Task<IActionResult> GetAll()
        {
            return base.GetAll();
        }

        public async Task<IActionResult> GetByLiTypeCustomer(int custId, string licType)
        {
            var result = await _reader.GetByLiTypeCustomer(custId, licType);
            return Ok(result);
        }
    }
}

