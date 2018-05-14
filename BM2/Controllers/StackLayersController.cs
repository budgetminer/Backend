using BM2.Business.Base;
using BM2.Business.Readers.Definitions;
using BM2.Business.Writers.Definitions;
using BM2.DataAccess.BMEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.Controllers
{
    public class StacklayersController : ControllerBase<Stacklayer>
    {
        public StacklayersController(IStacklayerReader reader, IStacklayerWriter writer) : base(reader, writer)
        {

        }
    }
}
