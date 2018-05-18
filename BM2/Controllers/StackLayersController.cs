using BudgetMiner.Business.Base;
using BudgetMiner.Business.Readers.Definitions;
using BudgetMiner.Business.Writers.Definitions;
using BudgetMiner.DataAccess.BMEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Controllers
{
    public class StacklayersController : ControllerBase<Stacklayer>
    {
        public StacklayersController(IStacklayerReader reader, IStacklayerWriter writer) : base(reader, writer)
        {

        }
    }
}
